using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace Top_Reparações
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtPasse.UseSystemPasswordChar = true;
            //Encontrar o smtp na base de dados
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "SELECT Parametros.Conteudo, Parametros.Parametro FROM Parametros where Conteudo='SMTP'";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtSMTP.Text = dr[1].ToString();
            }
            con.Close();
            //Encontrar a passe na base de dados
            con.Open();
            query = "SELECT Parametros.Conteudo, Parametros.Parametro FROM Parametros where Conteudo='Passe'";
            cmd = new SqlCeCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPasse.Text = dr[1].ToString();
            }
            con.Close();
            //Encontrar o email na base de dados
            con.Open();
            query = "SELECT Parametros.Conteudo, Parametros.Parametro FROM Parametros where Conteudo='Email'";
            cmd = new SqlCeCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtEmail.Text = dr[1].ToString();
            }
            con.Close();
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

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Tem de preencher o Email para criar/alterar", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    return;
                }

                SqlCeConnection con = new
                    SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
                con.Open();
                string query = "SELECT COUNT(*) FROM Parametros WHERE Email = @Email";
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                int records = (int)cmd.ExecuteScalar();

                if (records == 0)
                {
                    query = "INSERT INTO Parametros (Parametro, Conteudo) VALUES (@Parametro, @Conteudo)";
                    cmd = new SqlCeCommand(query, con);

                    cmd.Parameters.AddWithValue("@Parametro", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Conteudo", "Email");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Email Inserido.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    query = "UPDATE Parametros SET " +
                    "Parametro=@Parametro" +
                    "Where Conteudo='Email'";

                    cmd = new SqlCeCommand(query, con);
                    cmd.Parameters.AddWithValue("@Parametro", txtEmail.Text);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Email editado.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
        }

        private void txtPasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtPasse.Text))
                {
                    MessageBox.Show("Tem de preencher a passe para criar/alterar", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    return;
                }

                SqlCeConnection con = new
                    SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
                con.Open();
                string query = "SELECT COUNT(*) FROM Parametros WHERE Conteudo = @Conteudo";
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.Parameters.AddWithValue("@Conteudo", "Passe");
                int records = (int)cmd.ExecuteScalar();

                if (records == 0)
                {
                    query = "INSERT INTO Parametros (Parametro, Conteudo) VALUES (@Parametro, @Conteudo)";
                    cmd = new SqlCeCommand(query, con);

                    cmd.Parameters.AddWithValue("@Parametro", txtPasse.Text);
                    cmd.Parameters.AddWithValue("@Conteudo", "Passe");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Palavra-Passe Inserida.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (records == 1)
                {
                    query = "UPDATE Parametros SET " +
                    "Parametro=@Parametro " +
                    "Where Conteudo='Passe'";

                    cmd = new SqlCeCommand(query, con);
                    cmd.Parameters.AddWithValue("@Parametro", txtPasse.Text);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Palavra-Passe editada.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
        }

        private void txtSMTP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtSMTP.Text))
                {
                    MessageBox.Show("Tem de preencher o SMTP para criar/alterar", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    return;
                }

                SqlCeConnection con = new
                    SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
                con.Open();
                string query = "SELECT COUNT(*) FROM Parametros WHERE Conteudo = @Conteudo";
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.Parameters.AddWithValue("@Conteudo", "SMTP");
                int records = (int)cmd.ExecuteScalar();

                if (records == 0)
                {
                    query = "INSERT INTO Parametros (Parametro, Conteudo) VALUES (@Parametro, @Conteudo)";
                    cmd = new SqlCeCommand(query, con);

                    cmd.Parameters.AddWithValue("@Parametro", txtSMTP.Text);
                    cmd.Parameters.AddWithValue("@Conteudo", "SMTP");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SMTP Inserido.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (records == 1)
                {
                    query = "UPDATE Parametros SET " +
                    "Parametro=@Parametro " +
                    "Where Conteudo='SMTP'";

                    cmd = new SqlCeCommand(query, con);
                    cmd.Parameters.AddWithValue("@Parametro", txtSMTP.Text);
                    cmd.ExecuteScalar();
                    MessageBox.Show("SMTP editado.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
