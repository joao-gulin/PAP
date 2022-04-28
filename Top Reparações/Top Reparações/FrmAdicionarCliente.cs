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
    public partial class FrmAdicionarCliente : Form
    {
        public FrmAdicionarCliente()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        int novoID;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Insira o nome ou numero de telefone!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCeConnection con = new
                SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
                con.Open();
                string query = "INSERT INTO Clientes(" +
                    "IDCliente,Nome,Contribuinte,Telefone,Email,Morada,Contactos)" +
                    "VALUES (@IDCliente,@Nome,@Contribuinte,@Telefone,@Email,@Morada,@Contactos)";
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Contribuinte", txtContribuinte.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                cmd.Parameters.AddWithValue("@Contactos", txtContactos.Text);
                cmd.ExecuteScalar();
                MessageBox.Show("Cliente Inserido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor; //cursor em espera
                frmClientes form = new frmClientes();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void FrmAdicionarCliente_Load(object sender, EventArgs e)
        {
                string query = "SELECT MAX(IDCliente) FROM Clientes";
                novoID = 0;
                using (SqlCeConnection con =
                    new SqlCeConnection(@"DataSource=|DataDirectory|\Top Reparacoes.sdf"))
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(query, con))
                    {
                        con.Open();
                        novoID = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                        txtIDCliente.Text = novoID.ToString();
                    }
                    con.Close();
                }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtContribuinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmClientes form = new frmClientes();
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
