
namespace Top_Reparações
{
    partial class frmServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDireito = new System.Windows.Forms.Panel();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnDetalhes = new FontAwesome.Sharp.IconButton();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnComprovativo = new FontAwesome.Sharp.IconButton();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.painelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtnServico = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnExportarQRCode = new FontAwesome.Sharp.IconButton();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.panelDireito.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.painelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtnServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDireito
            // 
            this.panelDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelDireito.Controls.Add(this.btnConfig);
            this.panelDireito.Controls.Add(this.btnDetalhes);
            this.panelDireito.Controls.Add(this.btnExportar);
            this.panelDireito.Controls.Add(this.btnComprovativo);
            this.panelDireito.Controls.Add(this.btnAlterar);
            this.panelDireito.Controls.Add(this.btnAdicionar);
            this.panelDireito.Controls.Add(this.btnClientes);
            this.panelDireito.Controls.Add(this.panel2);
            this.panelDireito.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDireito.Location = new System.Drawing.Point(0, 0);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(294, 564);
            this.panelDireito.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnConfig.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Atom;
            this.btnConfig.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 505);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(294, 59);
            this.btnConfig.TabIndex = 8;
            this.btnConfig.Text = "Configuração";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetalhes.Enabled = false;
            this.btnDetalhes.FlatAppearance.BorderSize = 0;
            this.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDetalhes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDetalhes.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnDetalhes.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnDetalhes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalhes.IconSize = 32;
            this.btnDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalhes.Location = new System.Drawing.Point(0, 447);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(294, 59);
            this.btnDetalhes.TabIndex = 7;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalhes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalhes.UseVisualStyleBackColor = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnExportar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportar.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 32;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(0, 388);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(294, 59);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnComprovativo
            // 
            this.btnComprovativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnComprovativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComprovativo.Enabled = false;
            this.btnComprovativo.FlatAppearance.BorderSize = 0;
            this.btnComprovativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprovativo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnComprovativo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnComprovativo.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnComprovativo.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnComprovativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprovativo.IconSize = 32;
            this.btnComprovativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprovativo.Location = new System.Drawing.Point(0, 329);
            this.btnComprovativo.Name = "btnComprovativo";
            this.btnComprovativo.Size = new System.Drawing.Size(294, 59);
            this.btnComprovativo.TabIndex = 4;
            this.btnComprovativo.Text = "Comprovativo/Levantamento";
            this.btnComprovativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprovativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprovativo.UseVisualStyleBackColor = false;
            this.btnComprovativo.Click += new System.EventHandler(this.btnComprovativo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnAlterar.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterar.IconSize = 32;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(0, 270);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(294, 59);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Editar Serviço";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdicionar.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionar.IconSize = 32;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 211);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(294, 59);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Serviço";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnClientes.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 152);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(294, 59);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Gerir Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 152);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Top_Reparações.Properties.Resources._34071678_689835887853735_8130190550922952704_n;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(510, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serviços";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 75);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(1006, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 31);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnFechar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 25;
            this.btnFechar.Location = new System.Drawing.Point(1041, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 31);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painelDesktop
            // 
            this.painelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelDesktop.BackColor = System.Drawing.Color.Snow;
            this.painelDesktop.Controls.Add(this.label2);
            this.painelDesktop.Controls.Add(this.dtnServico);
            this.painelDesktop.Controls.Add(this.txtPesquisa);
            this.painelDesktop.Controls.Add(this.btnExportarQRCode);
            this.painelDesktop.Controls.Add(this.picQRCode);
            this.painelDesktop.ForeColor = System.Drawing.Color.Snow;
            this.painelDesktop.Location = new System.Drawing.Point(294, 75);
            this.painelDesktop.Name = "painelDesktop";
            this.painelDesktop.Size = new System.Drawing.Size(1610, 781);
            this.painelDesktop.TabIndex = 2;
            this.painelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.painelDesktop_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Procurar Serviço:";
            // 
            // dtnServico
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtnServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtnServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtnServico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtnServico.Location = new System.Drawing.Point(17, 77);
            this.dtnServico.Name = "dtnServico";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtnServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtnServico.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtnServico.RowTemplate.Height = 30;
            this.dtnServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtnServico.Size = new System.Drawing.Size(849, 377);
            this.dtnServico.TabIndex = 11;
            this.dtnServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtnServico_CellClick_1);
            this.dtnServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtnServico_CellContentClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(17, 46);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(245, 25);
            this.txtPesquisa.TabIndex = 15;
            this.txtPesquisa.Click += new System.EventHandler(this.txtPesquisa_Click);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnExportarQRCode
            // 
            this.btnExportarQRCode.Enabled = false;
            this.btnExportarQRCode.FlatAppearance.BorderSize = 0;
            this.btnExportarQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarQRCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnExportarQRCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.btnExportarQRCode.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnExportarQRCode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.btnExportarQRCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarQRCode.Location = new System.Drawing.Point(1200, 431);
            this.btnExportarQRCode.Name = "btnExportarQRCode";
            this.btnExportarQRCode.Size = new System.Drawing.Size(394, 65);
            this.btnExportarQRCode.TabIndex = 16;
            this.btnExportarQRCode.Text = "Exportar QRCode";
            this.btnExportarQRCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarQRCode.UseVisualStyleBackColor = true;
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(1200, 77);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(394, 351);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 13;
            this.picQRCode.TabStop = false;
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 564);
            this.Controls.Add(this.painelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDireito);
            this.Name = "frmServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmServico_Activated);
            this.Load += new System.EventHandler(this.frmServico_Load);
            this.Shown += new System.EventHandler(this.frmServico_Shown);
            this.panelDireito.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelDesktop.ResumeLayout(false);
            this.painelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtnServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDireito;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnComprovativo;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painelDesktop;
        private FontAwesome.Sharp.IconButton btnFechar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnDetalhes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnExportarQRCode;
        private System.Windows.Forms.PictureBox picQRCode;
        private FontAwesome.Sharp.IconButton btnConfig;
        private System.Windows.Forms.DataGridView dtnServico;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
    }
}