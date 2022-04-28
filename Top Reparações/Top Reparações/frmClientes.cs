using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_Reparações
{
    public partial class frmClientes : Form
    {
        private IconButton btnAtual;
        private Panel painelDireito;
        public frmClientes()
        {
            InitializeComponent();
            painelDireito = new Panel();
            painelDireito.Size = new Size(7, 60);
            panelDireito.Controls.Add(painelDireito);
            btnAtual = new IconButton();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        string filtroCliente = "SELECT * FROM Clientes order by IDCliente";

        private void Reset()
        {
            painelDireito.Visible = false;
        }

        private void CarregaData()
        {
            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            string query = filtroCliente;
            SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
            da.Fill(dt);
            bs.DataSource = dt;
            dtnClientes.DataSource = bs;
            con.Close();
        }

        private void FormataData()
        {
            // proteger a grid contra escrita
            dtnClientes.ReadOnly = true;
            // retirar linha de AddNew
            dtnClientes.AllowUserToAddRows = false;
            // retirar cabeçalho das linhas 
            dtnClientes.RowHeadersVisible = false;

            // para centrar os títulos da grid            
            dtnClientes.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            //// para colocar a negrito os títulos da grid
            dtnClientes.ColumnHeadersDefaultCellStyle.Font =
                new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // alterar títulos colunas
            dtnClientes.Columns[0].HeaderText = "N.º Cliente";

            // alinhar colunas ao centro
            dtnClientes.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dtnClientes.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // alinhar colunas à direita
            dtnClientes.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            // Editar o RowTemplate diretamente nas propriedades para
            // Font (DefaultCellStyle) e altura das linhas (Heigh)

            // alterar largura de colunas
            dtnClientes.Columns[0].Width = 50;
            dtnClientes.Columns[1].Width = 250;
            dtnClientes.Columns[2].Width = 120;
            dtnClientes.Columns[4].Width = 250;
            dtnClientes.Columns[5].Width = 120;
        }

        private void txtProcurarClientes_TextChanged(object sender, EventArgs e)
        {
            filtroCliente = "select * from Clientes where Nome like '%" +
                txtProcurarClientes.Text + "%' or Nome like '%" +
                txtProcurarClientes.Text + "%' or IDCliente like '%" +
                txtProcurarClientes.Text + "%' or Telefone like '%" +
                txtProcurarClientes.Text + "%' or Email like '%" +
                txtProcurarClientes.Text + "%' or Contribuinte like '%" +
                txtProcurarClientes.Text + "%' or Contactos like '%" +
                txtProcurarClientes.Text + "%'";
            CarregaData();
        }

        private void frmClientes_Activated(object sender, EventArgs e)
        {
            CarregaData();
            FormataData();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            FrmAdicionarCliente form = new FrmAdicionarCliente();
            form.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmServico form = new frmServico();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PassaDados.valor = dtnClientes.CurrentRow.Cells[0].Value.ToString();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmVizualisarEditarCliente form = new frmVizualisarEditarCliente();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmServico form = new frmServico();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            FrmAdicionarCliente form = new FrmAdicionarCliente();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
