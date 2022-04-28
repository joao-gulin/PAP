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
    public partial class frmAdicionarDetalhes : Form
    {
        public frmAdicionarDetalhes()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Tem de preencher o Produto e o Preço", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                return;
            }

            SqlCeConnection con = new
                SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "INSERT INTO Detalhes(" +
                "FK_IDReparacao,Descricao,Preco,Quantidade)" +
                "VALUES (@FK_IDReparacao,@Descricao,@Preco,@Quantidade)";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@FK_IDReparacao", txtIDServico.Text);
            cmd.Parameters.AddWithValue("@Descricao", txtProduto.Text);
            cmd.Parameters.AddWithValue("@Quantidade", nudQuantidade.Text);
            cmd.Parameters.AddWithValue("@Preco", txtPreco.Text);
            try
            {
                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("O produto <" + txtProduto.Text + "> já foi inserido",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            MessageBox.Show("Detalhe inserido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Detalhes form = new Detalhes();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void frmAdicionarDetalhes_Load(object sender, EventArgs e)
        {
            txtIDServico.Text = PassaDados.valor2;
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            double valor;
            if (!double.TryParse(txtPreco.Text, out valor))
                MessageBox.Show("Preço incorreto.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

            if (double.Parse(txtPreco.Text) < 0)
            {
                MessageBox.Show("Preço incorreto.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Detalhes form = new Detalhes();
            this.Hide();
            form.ShowDialog();
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
    }
}
