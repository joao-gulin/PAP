
namespace Top_Reparações
{
    partial class FrmAdicionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdicionarProduto));
            this.txtIDReparacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtnChegada = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.dtnReparacao = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.picQRCODE = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcurarClientes = new System.Windows.Forms.TextBox();
            this.rbtNaoPago = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtnReparacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCODE)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDReparacao
            // 
            this.txtIDReparacao.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIDReparacao.ForeColor = System.Drawing.Color.Black;
            this.txtIDReparacao.Location = new System.Drawing.Point(12, 284);
            this.txtIDReparacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDReparacao.Name = "txtIDReparacao";
            this.txtIDReparacao.Size = new System.Drawing.Size(147, 24);
            this.txtIDReparacao.TabIndex = 0;
            this.txtIDReparacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDReparacao.TextChanged += new System.EventHandler(this.txtIDReparacao_TextChanged);
            this.txtIDReparacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDReparacao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "IDReparação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(280, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Relatório da Avaria";
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRelatorio.ForeColor = System.Drawing.Color.Black;
            this.txtRelatorio.Location = new System.Drawing.Point(283, 173);
            this.txtRelatorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(300, 543);
            this.txtRelatorio.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 658);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(260, 58);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Validar Reparação";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtnChegada
            // 
            this.dtnChegada.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtnChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnChegada.Location = new System.Drawing.Point(13, 567);
            this.dtnChegada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtnChegada.Name = "dtnChegada";
            this.dtnChegada.Size = new System.Drawing.Size(243, 23);
            this.dtnChegada.TabIndex = 20;
            this.dtnChegada.ValueChanged += new System.EventHandler(this.dtnChegada_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Data de Chegada";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIDCliente.ForeColor = System.Drawing.Color.Black;
            this.txtIDCliente.Location = new System.Drawing.Point(12, 340);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(147, 24);
            this.txtIDCliente.TabIndex = 25;
            this.txtIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "IDCliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Responsavel";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtResponsavel.ForeColor = System.Drawing.Color.Black;
            this.txtResponsavel.Location = new System.Drawing.Point(12, 450);
            this.txtResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(167, 24);
            this.txtResponsavel.TabIndex = 49;
            this.txtResponsavel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtnReparacao
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtnReparacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtnReparacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtnReparacao.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtnReparacao.Location = new System.Drawing.Point(612, 52);
            this.dtnReparacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtnReparacao.Name = "dtnReparacao";
            this.dtnReparacao.Size = new System.Drawing.Size(647, 664);
            this.dtnReparacao.TabIndex = 54;
            this.dtnReparacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtnReparacao_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(13, 395);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 24);
            this.txtNome.TabIndex = 57;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 369);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 21);
            this.label14.TabIndex = 56;
            this.label14.Text = "Nome do Cliente";
            // 
            // picQRCODE
            // 
            this.picQRCODE.Location = new System.Drawing.Point(14, 32);
            this.picQRCODE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picQRCODE.Name = "picQRCODE";
            this.picQRCODE.Size = new System.Drawing.Size(242, 215);
            this.picQRCODE.TabIndex = 58;
            this.picQRCODE.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(911, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Pesquisar Clientes:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtProcurarClientes
            // 
            this.txtProcurarClientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtProcurarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.txtProcurarClientes.Location = new System.Drawing.Point(612, 24);
            this.txtProcurarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcurarClientes.Name = "txtProcurarClientes";
            this.txtProcurarClientes.Size = new System.Drawing.Size(191, 24);
            this.txtProcurarClientes.TabIndex = 59;
            this.txtProcurarClientes.TextChanged += new System.EventHandler(this.txtProcurarClientes_TextChanged);
            // 
            // rbtNaoPago
            // 
            this.rbtNaoPago.AutoSize = true;
            this.rbtNaoPago.BackColor = System.Drawing.Color.White;
            this.rbtNaoPago.Checked = true;
            this.rbtNaoPago.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtNaoPago.ForeColor = System.Drawing.Color.Red;
            this.rbtNaoPago.Location = new System.Drawing.Point(13, 506);
            this.rbtNaoPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtNaoPago.Name = "rbtNaoPago";
            this.rbtNaoPago.Size = new System.Drawing.Size(61, 25);
            this.rbtNaoPago.TabIndex = 61;
            this.rbtNaoPago.TabStop = true;
            this.rbtNaoPago.Text = "Não";
            this.rbtNaoPago.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Pago ?:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(280, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Equipamento";
            // 
            // txtEquipamento
            // 
            this.txtEquipamento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEquipamento.ForeColor = System.Drawing.Color.Black;
            this.txtEquipamento.Location = new System.Drawing.Point(283, 47);
            this.txtEquipamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEquipamento.Multiline = true;
            this.txtEquipamento.Name = "txtEquipamento";
            this.txtEquipamento.Size = new System.Drawing.Size(300, 96);
            this.txtEquipamento.TabIndex = 65;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(1189, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 31);
            this.btnMinimizar.TabIndex = 100;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnFechar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 25;
            this.btnFechar.Location = new System.Drawing.Point(1227, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 31);
            this.btnFechar.TabIndex = 99;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // FrmAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1271, 729);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtEquipamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtNaoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProcurarClientes);
            this.Controls.Add(this.picQRCODE);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtnReparacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtnChegada);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDReparacao);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Reparação";
            this.Load += new System.EventHandler(this.FrmAdicionarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtnReparacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCODE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDReparacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtnChegada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picQRCODE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcurarClientes;
        private System.Windows.Forms.RadioButton rbtNaoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEquipamento;
        private System.Windows.Forms.DataGridView dtnReparacao;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
    }
}