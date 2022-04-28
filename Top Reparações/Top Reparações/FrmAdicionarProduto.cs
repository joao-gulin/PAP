using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Top_Reparações
{
    public partial class FrmAdicionarProduto : Form
    {
        public FrmAdicionarProduto()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        string filtroReparacao = "SELECT * FROM Clientes order by Nome asc";

        private void FrmAdicionarProduto_Load(object sender, EventArgs e)
        {
            txtIDReparacao.ReadOnly = true;
            txtIDCliente.ReadOnly = true;
            txtNome.ReadOnly = true;
            if (txtIDReparacao.Text == "")
            {
                txtIDReparacao.ReadOnly = false;
            }
            else
            {
                txtIDReparacao.ReadOnly = true;
            }
            CarregaDataReparacao();
            FormataData();
            string query = "SELECT MAX(IDReparacao) FROM Reparacao";
            int novoID;
            using (SqlCeConnection con =
                new SqlCeConnection(@"DataSource=|DataDirectory|\Top Reparacoes.sdf"))
            {
                using (SqlCeCommand cmd = new SqlCeCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        novoID = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    }
                    catch
                    {
                        txtIDReparacao.Text = "1";
                        con.Close();
                        return;
                    }
                    txtIDReparacao.Text = novoID.ToString();
                }
                con.Close();
            }
        }

        private void CarregaDataReparacao()
        {
            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            string query = filtroReparacao;
            SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
            da.Fill(dt);
            bs.DataSource = dt;
            dtnReparacao.DataSource = bs;
            con.Close();
        }

        private void FormataData()
        {
            dtnReparacao.ReadOnly = true;
            dtnReparacao.AllowUserToAddRows = false;
            dtnReparacao.RowHeadersVisible = false;
            dtnReparacao.Columns[0].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnReparacao.Columns[2].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnReparacao.Columns[3].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnReparacao.Columns[5].Width = 200;
            dtnReparacao.Columns[4].Width = 180;
            dtnReparacao.Columns[3].Width = 80;
            dtnReparacao.Columns[2].Width = 65;
            dtnReparacao.Columns[1].Width = 130;
            dtnReparacao.Columns[0].Width = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Por-favor selecione o cliente que deseja atribuir a reparação", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCeConnection con = new
                SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
                con.Open();
                string query = "INSERT INTO Reparacao(" +
                    "IDReparacao,IDCliente,Nome,Equipamento,DataRec,Relatorio,Responsavel,QRCode,Estado,Pago)" +
                    "VALUES (@IDReparacao,@IDCliente,@Nome,@Equipamento,@DataRec,@Relatorio,@Responsavel,@QRCode,@Estado,@Pago)";
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.Parameters.AddWithValue("@IDReparacao", txtIDReparacao.Text);
                cmd.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Equipamento", txtEquipamento.Text);
                cmd.Parameters.AddWithValue("@DataRec", dtnChegada.Text);
                cmd.Parameters.AddWithValue("@Relatorio", txtRelatorio.Text);
                cmd.Parameters.AddWithValue("@Responsavel", txtResponsavel.Text);
                cmd.Parameters.AddWithValue("@Estado", "Pendente");
                if (rbtNaoPago.Checked)
                {
                    cmd.Parameters.AddWithValue("@Pago", rbtNaoPago.Text);
                }

                MemoryStream ms = new MemoryStream();
                picQRCODE.Image.Save(ms, ImageFormat.Png);
                byte[] pic_arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic_arr, 0, pic_arr.Length);
                cmd.Parameters.AddWithValue("@QRCode", pic_arr);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reparação Criada com sucesso", "Informação" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor; //cursor em espera
                frmServico form = new frmServico();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void txtIDReparacao_TextChanged(object sender, EventArgs e)
        {
            txtIDCliente.ReadOnly = false;
            var QRText = txtIDReparacao.Text + "\n" +
                "" + txtNome.Text + "\n" +
                dtnChegada.Text;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picQRCODE.Image = qrcode.Draw(QRText, 50);
            txtIDCliente.ReadOnly = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtIDCliente.ReadOnly = false;
            var QRText = txtIDReparacao.Text + "\n" +
                txtNome.Text + "\n" +
                dtnChegada.Text;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picQRCODE.Image = qrcode.Draw(QRText, 50);
            txtIDCliente.ReadOnly = true;
        }

        private void dtnChegada_ValueChanged(object sender, EventArgs e)
        {
            txtIDCliente.ReadOnly = false;
            var QRText = txtIDReparacao.Text + "\n" +
                txtNome.Text + "\n" +
                dtnChegada.Text;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picQRCODE.Image = qrcode.Draw(QRText, 50);
            txtIDCliente.ReadOnly = true;
        }

        private void dtnReparacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCliente.Text = dtnReparacao.CurrentRow.Cells[0].Value.ToString();
            txtIDCliente.ReadOnly = true;
            txtNome.ReadOnly = true;
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
                linhas++;
            }
            con.Close();
            if (linhas == 0)
            {
                MessageBox.Show("Cliente não encontrado.",
                    "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtProcurarClientes_TextChanged(object sender, EventArgs e)
        {
            filtroReparacao = "select * from Clientes where Nome like '%" +
                txtProcurarClientes.Text + "%' or Nome like '%" +
                txtProcurarClientes.Text + "%' or IDCliente like '%" +
                txtProcurarClientes.Text + "%' or Telefone like '%" +
                txtProcurarClientes.Text + "%' or Email like '%" +
                txtProcurarClientes.Text + "%' or Contribuinte like '%" +
                txtProcurarClientes.Text + "%' or Contactos like '%" +
                txtProcurarClientes.Text + "%'";
            CarregaDataReparacao();
        }

        private void txtIDReparacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
