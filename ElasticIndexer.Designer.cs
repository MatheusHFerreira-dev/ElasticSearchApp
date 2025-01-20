namespace ElasticIndexApp
{
    partial class ElasticIndexer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIndexar = new Button();
            btnCarregarPasta = new Button();
            lstArquivos = new ListBox();
            txtResultados = new RichTextBox();
            btnExecutarQuery = new Button();
            txtQueryCustom = new TextBox();
            btnBuscar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtUsuario = new TextBox();
            cmbIndexes = new ComboBox();
            lblPk = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnIndexar
            // 
            btnIndexar.Dock = DockStyle.Fill;
            btnIndexar.Location = new Point(3, 3);
            btnIndexar.Name = "btnIndexar";
            btnIndexar.Size = new Size(391, 59);
            btnIndexar.TabIndex = 1;
            btnIndexar.Text = "Indexar Selecionado";
            btnIndexar.UseVisualStyleBackColor = true;
            btnIndexar.Click += btnIndexar_Click;
            // 
            // btnCarregarPasta
            // 
            btnCarregarPasta.Dock = DockStyle.Fill;
            btnCarregarPasta.Location = new Point(400, 3);
            btnCarregarPasta.Name = "btnCarregarPasta";
            btnCarregarPasta.Size = new Size(391, 59);
            btnCarregarPasta.TabIndex = 0;
            btnCarregarPasta.Text = "Buscar documentos";
            btnCarregarPasta.UseVisualStyleBackColor = true;
            btnCarregarPasta.Click += btnCarregarPasta_Click;
            // 
            // lstArquivos
            // 
            lstArquivos.Dock = DockStyle.Fill;
            lstArquivos.FormattingEnabled = true;
            lstArquivos.ItemHeight = 15;
            lstArquivos.Location = new Point(3, 165);
            lstArquivos.Name = "lstArquivos";
            lstArquivos.Size = new Size(794, 136);
            lstArquivos.TabIndex = 1;
            // 
            // txtResultados
            // 
            txtResultados.Dock = DockStyle.Fill;
            txtResultados.Location = new Point(3, 449);
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.Size = new Size(794, 207);
            txtResultados.TabIndex = 2;
            txtResultados.Text = "";
            // 
            // btnExecutarQuery
            // 
            btnExecutarQuery.Dock = DockStyle.Fill;
            btnExecutarQuery.Location = new Point(3, 68);
            btnExecutarQuery.Name = "btnExecutarQuery";
            btnExecutarQuery.Size = new Size(332, 59);
            btnExecutarQuery.TabIndex = 0;
            btnExecutarQuery.Text = "Busca Personalizada";
            btnExecutarQuery.UseVisualStyleBackColor = true;
            btnExecutarQuery.Click += btnExecutarQuery_Click;
            // 
            // txtQueryCustom
            // 
            txtQueryCustom.Dock = DockStyle.Fill;
            txtQueryCustom.Location = new Point(3, 3);
            txtQueryCustom.Multiline = true;
            txtQueryCustom.Name = "txtQueryCustom";
            txtQueryCustom.PlaceholderText = "Digite sua query JSON aqui ...";
            txtQueryCustom.Size = new Size(444, 130);
            txtQueryCustom.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.Location = new Point(3, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(332, 59);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Busca por usuário";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtResultados, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(lstArquivos, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 680);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel2.Controls.Add(txtUsuario, 0, 0);
            tableLayoutPanel2.Controls.Add(cmbIndexes, 1, 0);
            tableLayoutPanel2.Controls.Add(lblPk, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 65);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Location = new Point(3, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário ...";
            txtUsuario.Size = new Size(575, 23);
            txtUsuario.TabIndex = 0;
            // 
            // cmbIndexes
            // 
            cmbIndexes.Dock = DockStyle.Fill;
            cmbIndexes.FormattingEnabled = true;
            cmbIndexes.Location = new Point(584, 3);
            cmbIndexes.Name = "cmbIndexes";
            cmbIndexes.Size = new Size(207, 23);
            cmbIndexes.TabIndex = 3;
            cmbIndexes.Click += cmbIndexes_Click;
            // 
            // lblPk
            // 
            lblPk.Dock = DockStyle.Fill;
            lblPk.Location = new Point(3, 43);
            lblPk.Name = "lblPk";
            lblPk.Size = new Size(575, 23);
            lblPk.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnCarregarPasta, 0, 0);
            tableLayoutPanel3.Controls.Add(btnIndexar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 94);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(794, 65);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6750641F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3249359F));
            tableLayoutPanel4.Controls.Add(txtQueryCustom, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 307);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(794, 136);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnBuscar, 0, 0);
            tableLayoutPanel5.Controls.Add(btnExecutarQuery, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(453, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(338, 130);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // ElasticIndexer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 680);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ElasticIndexer";
            Text = "Elastic Indexer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnIndexar;
        private RichTextBox txtResultados;
        private Button btnExecutarQuery;
        private TextBox txtQueryCustom;
        private Button btnBuscar;
        private Button btnCarregarPasta;
        private ListBox lstArquivos;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox cmbIndexes;
        private TextBox txtUsuario;
        private TextBox lblPk;
    }
}
