using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace Top_Reparações
{
    public partial class frmComprovativo : Form
    {
        public frmComprovativo()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        string dest = "";

        private void frmComprovativo_Load(object sender, EventArgs e)
        {
            //Adicionar Automaticamente a caixa de text IDServiço e Nome do cliente

            txtIDServico.Text = PassaDados.valor2;
            txtNome.Text = PassaDados.valor;

            //Buscar informações do serviços
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "SELECT * FROM Reparacao where IDReparacao=" + txtIDServico.Text;
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dtnData.Text = dr["DataRec"].ToString();
                txtDetalhes.Text = dr["Relatorio"].ToString();
                txtIDCliente.Text = dr["IDCliente"].ToString();
                txtEquipamento.Text = dr["Equipamento"].ToString();
            }

            //Buscar email do cliente
            query = "SELECT * FROM Clientes Where IDCliente=" + txtIDCliente.Text;
            cmd = new SqlCeCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDestinatario.Text = dr["Email"].ToString();
            }
            
            //Mensagem Automatica do comprovativo
            txtConteudo.Text = "Declaramos que no dia " + dtnData.Text + ", o cliente com Nº " + txtIDCliente.Text +
            ", dispos nos o equipamento " + txtEquipamento.Text + " com a seguinte descrição (" + txtDetalhes.Text + ")";

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

        private void button1_Click(object sender, EventArgs e)
        { 
            //Encontrar o smtp na base de dados
            var smtp = "";
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "SELECT Parametros.Conteudo, Parametros.Parametro FROM Parametros where Conteudo='SMTP'";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                smtp = dr[1].ToString();
            }
            con.Close();
            //Encontrar a passe na base de dados
            var senha = "";
            con.Open();
            query = "SELECT Parametros.Conteudo, Parametros.Parametro FROM Parametros where Conteudo='Passe'";
            cmd = new SqlCeCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                senha = dr[1].ToString();
            }
            con.Close();
            //Encontrar o email na base de dados
            var email = "";
            con.Open();
            query = "SELECT Parametros.Conteudo, Parametros.Parametro FROM Parametros where Conteudo='Email'";
            cmd = new SqlCeCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                email = dr[1].ToString();
            }
            con.Close();
            //Envio do email com anexo 
            var Assunto = txtAssunto.Text;
            var Conteudo = txtConteudo.Text;
            MailMessage mail = new MailMessage(email, txtDestinatario.Text, Assunto, Conteudo);
            SmtpClient client = new SmtpClient(smtp);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(email, senha);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Email mandado com sucesso", "Sucesso", MessageBoxButtons.OK);
        }
    }
}
