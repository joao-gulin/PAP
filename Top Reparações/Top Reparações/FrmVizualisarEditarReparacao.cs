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

namespace Top_Reparações
{
    public partial class FrmVizualisarEditarReparacao : Form
    {
        public FrmVizualisarEditarReparacao()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FrmVizualisarEditarReparacao_Load(object sender, EventArgs e)
        {
            txtIDReparacao.Text = PassaDados.valor;
            txtIDCliente.ReadOnly = true;
            txtNome.ReadOnly = true;

            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "SELECT * FROM Reparacao where IDReparacao='" + txtIDReparacao.Text + "'";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtIDReparacao.Text = dr["IDReparacao"].ToString();
                txtIDCliente.Text = dr["IDCliente"].ToString();
                txtNome.Text = dr["Nome"].ToString();
                txtEquipamento.Text = dr["Equipamento"].ToString();
                dtnChegada.Text = dr["DataRec"].ToString();
                txtRelatorio.Text = dr["Relatorio"].ToString();
                txtResponsavel.Text = dr["Responsavel"].ToString();
            }
            con.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "UPDATE Reparacao SET " +
                "IDReparacao=@IDReparacao," +
                "IDCliente=@IDCliente," +
                "Nome=@Nome," +
                "Equipamento=@Equipamento," +
                "DataRec=@DataRec," +
                "Relatorio=@Relatorio," +
                "Responsavel=@Responsavel," +
                "QRCode=@QRCode" +
                " where IDReparacao=@IDReparacao";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@IDReparacao", txtIDReparacao.Text);
            cmd.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Equipamento", txtEquipamento.Text);
            cmd.Parameters.AddWithValue("@DataRec", dtnChegada.Text);
            cmd.Parameters.AddWithValue("@Relatorio", txtRelatorio.Text);
            cmd.Parameters.AddWithValue("@Responsavel", txtResponsavel.Text);
            MemoryStream ms = new MemoryStream();
            picQRCODE.Image.Save(ms, ImageFormat.Png);
            byte[] pic_arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_arr, 0, pic_arr.Length);
            cmd.Parameters.AddWithValue("@QRCode", pic_arr);
            cmd.ExecuteScalar();
            MessageBox.Show("Reparação editada.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmServico form = new frmServico();
            this.Hide();
            form.ShowDialog();
            this.Close();
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
