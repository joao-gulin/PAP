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
    public partial class frmEditarDetalhes : Form
    {
        public frmEditarDetalhes()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmEditarDetalhes_Load(object sender, EventArgs e)
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "UPDATE Detalhes SET " +
                "Descricao=@Descricao," +
                "Preco=@Preco," +
                "Quantidade=@Quantidade " +
                " where FK_IDReparacao=@FK_IDReparacao";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@FK_IDReparacao", txtIDServico.Text);
            cmd.Parameters.AddWithValue("@Descricao", txtProduto.Text);
            cmd.Parameters.AddWithValue("@Preco", txtPreco.Text);
            cmd.Parameters.AddWithValue("@Quantidade", nudQuantidade.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Detalhe editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Detalhes form = new Detalhes();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmServico form = new frmServico();
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

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Detalhes form = new Detalhes();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
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
