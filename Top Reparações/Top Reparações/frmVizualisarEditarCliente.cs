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
    public partial class frmVizualisarEditarCliente : Form
    {
        public frmVizualisarEditarCliente()
        {
            InitializeComponent();
        }

        private void frmVizualisarEditarCliente_Load(object sender, EventArgs e)
        {
            txtIDCliente.Text = PassaDados.valor;
            txtIDCliente.ReadOnly = true;
            int linhas = 0;

            if (txtIDCliente.Text == "")
                return;

            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "SELECT * FROM Clientes where IDCliente='" + txtIDCliente.Text + "'";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = dr["Nome"].ToString();
                txtTelefone.Text = dr["Telefone"].ToString();
                txtContactos.Text = dr["Contactos"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtMorada.Text = dr["Morada"].ToString();
                txtContribuinte.Text = dr["Contribuinte"].ToString();
                linhas++;
            }
            con.Close();
            if (linhas == 0)
            {
                MessageBox.Show("Registro de colaborador não encontrado.",
                    "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "UPDATE Clientes SET " +
                "Nome=@Nome," +
                "Telefone=@Telefone," +
                "Contactos=@Contactos," +
                "Email=@Email," +
                "Morada=@Morada," +
                "Contribuinte=@Contribuinte" +
                " where IDCliente=@IDCliente";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@Contactos", txtContactos.Text);
            cmd.Parameters.AddWithValue("@Email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@Morada",txtMorada.Text);
            cmd.Parameters.AddWithValue("@Contribuinte",txtContribuinte.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Cliente editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmClientes form = new frmClientes();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void txtContribuinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmServico form = new frmServico();
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
