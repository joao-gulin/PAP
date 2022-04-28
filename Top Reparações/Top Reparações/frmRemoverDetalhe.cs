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
    public partial class frmRemoverDetalhe : Form
    {
        public frmRemoverDetalhe()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmRemoverDetalhe_Load(object sender, EventArgs e)
        {
            txtIDServico.Text = PassaDados.valor2;
            int linhas = 0;
            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "SELECT * FROM Detalhes where FK_IDReparacao='" + txtIDServico.Text + "'";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPreco.Text = dr["Preco"].ToString();
                txtProduto.Text = dr["Descricao"].ToString();
                nudQuantidade.Text = dr["Quantidade"].ToString();
                linhas++;
            }
            con.Close();
            if (linhas == 0)
            {
                MessageBox.Show("Registro de colaborador não encontrado.",
                    "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza? Que deseja remover o detalhe",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "DELETE FROM Detalhes WHERE Descricao = @Descricao";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@Descricao", txtProduto.Text);
            cmd.ExecuteScalar();
            con.Close();
            MessageBox.Show("Detalhe Removido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
