using Elasticsearch.Net;
using Nest;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ElasticIndexApp
{
    public partial class ElasticIndexer : Form
    {
        private ElasticClient client;
        public ElasticIndexer()
        {
            InitializeComponent();


            var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
                .DefaultIndex("default_index");
            client = new ElasticClient(settings);

            CarregarIndices();
        }

        private void CarregarIndices()
        {
            try
            {
                var response = client.Indices.Get(new GetIndexRequest(Indices.All));

                cmbIndexes.Items.Clear();

                if (response.IsValid)
                {
                    foreach (var index in response.Indices.Keys)
                    {
                        if (!index.Name.StartsWith(".kibana"))
                        {
                            cmbIndexes.Items.Add(index);
                        }
                    }                
                    if (cmbIndexes.Items.Count > 0)
                        cmbIndexes.SelectedIndex = 0;
                    
                }
                else
                {
                    MessageBox.Show($"Erro ao buscar índices: {response.ServerError}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar índices: {ex.Message}");
            }
        }

        private void btnCarregarPasta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lstArquivos.Items.Clear();

                    foreach (var fileName in openFileDialog.FileNames)
                    {
                        lstArquivos.Items.Add(fileName);
                    }

                    MessageBox.Show("Documentos encontrados com sucesso!");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, insira o usuário para realizar a busca.");
                return;
            }
            var selectedIndex = cmbIndexes.SelectedItem ?? "default_index";

            string pKey = GerarPKey(txtUsuario.Text);

            try
            {
                var searchResponse = client.Search<object>(s => s
                    .Index(selectedIndex.ToString())
                    .Query(q => q
                        .Match(m => m
                            .Field("PKey")
                            .Query(pKey)
                        )
                    )
                );

                if (searchResponse.IsValid)
                {
                    txtResultados.Clear();
                    if (searchResponse.Hits.Count == 0)
                        txtResultados.AppendText("Nada encontrado...");

                    foreach (var hit in searchResponse.Hits)
                    {
                        ExibirResultadosNoRichTextBox(hit.Source);
                    }
                }
                else
                {
                    MessageBox.Show($"Erro na pesquisa: {searchResponse.ServerError}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnIndexar_Click(object sender, EventArgs e)
        {
            if (lstArquivos.Items.Count == 0)
            {
                MessageBox.Show("Por favor, busque os documentos antes de indexar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, insira o usuário antes de indexar os arquivos.");
                return;
            }

            var selectedIndex = cmbIndexes.SelectedItem ?? "default_index";


            string pKey = GerarPKey(txtUsuario.Text);

            foreach (var item in lstArquivos.Items)
            {
                string filePath = item.ToString();

                try
                {
                    string jsonContent = File.ReadAllText(filePath);

                    var document = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonContent);
                    document.PKey = pKey;

                    string updatedJson = Newtonsoft.Json.JsonConvert.SerializeObject(document);

                    var indexResponse = client.LowLevel.Index<BytesResponse>(selectedIndex.ToString(), PostData.String(updatedJson));

                    if (!indexResponse.Success)
                    {
                        MessageBox.Show($"Erro ao indexar arquivo {filePath}: {indexResponse.DebugInformation}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao processar arquivo {filePath}: {ex.Message}");
                }
            }

            MessageBox.Show("Arquivos indexados com sucesso!");
        }

        private void btnExecutarQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQueryCustom.Text))
            {
                MessageBox.Show("Por favor, insira uma query válida no campo.");
                return;
            }

            try
            {
                string rawQuery = txtQueryCustom.Text.Trim();

                string[] lines = rawQuery.Split('\n');
                string endpoint = lines[0].Replace("GET", "").Trim();

                string jsonQuery = string.Join("\n", lines.Skip(1)).Trim();

                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("http://localhost:9200");

                    var content = new StringContent(jsonQuery, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(endpoint, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        txtResultados.Clear();

                        string result = response.Content.ReadAsStringAsync().Result;
                        var jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
                        var hits = jsonObject.hits.hits;

                        foreach (var hit in hits)
                        {
                            ExibirResultadosNoRichTextBox(hit);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Erro na execução da query: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void cmbIndexes_Click(object sender, EventArgs e)
        {
            CarregarIndices();
        }

        private string GerarPKey(string input)
        {
            string pkCript = string.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                pkCript = builder.ToString();
            }

            lblPk.Text = pkCript;
            lblPk.ForeColor = Color.Green;

            return pkCript;

        }

        private void ExibirResultadosNoRichTextBox(object source)
        {
            try
            {
                var formattedJson = Newtonsoft.Json.JsonConvert.SerializeObject(source, Newtonsoft.Json.Formatting.Indented);
                txtResultados.AppendText(formattedJson + Environment.NewLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao formatar o JSON: {ex.Message}");
            }
        }

    }

}
