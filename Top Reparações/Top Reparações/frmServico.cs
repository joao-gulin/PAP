using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Office.Interop.Excel;
using Raven.Client.ServerWide.Operations.Certificates;

namespace Top_Reparações
{
    public partial class frmServico : Form
    {
        private IconButton btnAtual;
        private Panel painelDireito;
        string filtroReparacao = "SELECT * FROM Reparacao order by IDReparacao";
        string FilePath;

        public frmServico()
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

        private void CarregaDataReparacao()
        {
            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            System.Data.DataTable dt = new System.Data.DataTable();
            BindingSource bs = new BindingSource();
            string query = filtroReparacao;
            SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
            da.Fill(dt);
            bs.DataSource = dt;
            dtnServico.DataSource = bs;
            con.Close();
        }

        private void Desbloquear()
        {
            btnAlterar.Enabled = true;
            btnComprovativo.Enabled = true;
            btnDetalhes.Enabled = true;
            btnExportarQRCode.Enabled = true;
        }
        
        private void Reset()
        {
            painelDireito.Visible = false;
            btnExportar.Enabled = true;
            btnAlterar.Enabled = false;
            btnComprovativo.Enabled = false;
            btnDetalhes.Enabled = false;
            picQRCode.Image = null;
            picQRCode.Update();
            btnExportarQRCode.Enabled = false;
        }
        private void FormataData()
        {
            dtnServico.ReadOnly = true;
            dtnServico.AllowUserToAddRows = false;
            dtnServico.RowHeadersVisible = false;
            dtnServico.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dtnServico.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(DataGridView.DefaultFont, FontStyle.Bold);
            dtnServico.Columns[0].HeaderText = "N.º Serviço";
            dtnServico.Columns[1].HeaderText = "N.º Cliente";
            dtnServico.Columns[4].HeaderText = "Data de Recebimento";
            dtnServico.Columns[5].HeaderText = "Data de Entrega";
            dtnServico.Columns[6].HeaderText = "Relatório";
            dtnServico.Columns[7].HeaderText = "Responsável";
            dtnServico.Columns[10].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnServico.Columns[11].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnServico.Columns[1].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnServico.Columns[0].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            dtnServico.Columns[8].Visible = false;
            dtnServico.Columns[0].Width = 50;
            dtnServico.Columns[1].Width = 50;
            dtnServico.Columns[2].Width = 130;
            dtnServico.Columns[3].Width = 270;
            dtnServico.Columns[4].Width = 100;
            dtnServico.Columns[5].Width = 100;
            dtnServico.Columns[9].Width = 70;
            dtnServico.Columns[10].Width = 90;
            dtnServico.Columns["Valor"].DefaultCellStyle.Format = "N2";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void LiberarCaptura();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void MandarMensagem(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void ForeColor()
        {
            foreach (DataGridViewRow row in dtnServico.Rows)
            {
                string RowType = row.Cells[10].Value.ToString();

                if (RowType == "Pendente")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                }
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmClientes form = new frmClientes();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            FrmAdicionarProduto form = new FrmAdicionarProduto();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            FrmVizualisarEditarReparacao form = new FrmVizualisarEditarReparacao();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
           
        private void btnComprovativo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmComprovativo form = new frmComprovativo();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LiberarCaptura();
            MandarMensagem(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Folha1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dtnServico.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtnServico.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dtnServico.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtnServico.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtnServico.Rows[i].Cells[j].Value.ToString();
                }
            }
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel files (*.xls)|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs("c:\\", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();
                }
            }
        }

        private void btnVerDados_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            PassaDados.valor3 = dtnServico.CurrentRow.Cells[11].Value.ToString();
            PassaDados.valor2 = dtnServico.CurrentRow.Cells[0].Value.ToString();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Detalhes form = new Detalhes();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void frmServico_Activated(object sender, EventArgs e)
        {
            CarregaDataReparacao();
            FormataData();
            ForeColor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "Nome do cliente")
                return;

            filtroReparacao = "select * from Reparacao where IDReparacao like '%" +
                txtPesquisa.Text + "%' or IDReparacao like '%" +
                txtPesquisa.Text + "%' or IDCliente like '%" +
                txtPesquisa.Text + "%' or Nome like '%" +
                txtPesquisa.Text + "%'";
            CarregaDataReparacao();
            ForeColor();
        }

        private void icoReset_Click(object sender, EventArgs e)
        {
            filtroReparacao = "SELECT * FROM Reparacao order by Nome";
            CarregaDataReparacao();
            ForeColor();
        }

        private void frmServico_Shown(object sender, EventArgs e)
        {
            ForeColor();
        }

        private void dtnServico_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Desbloquear();
            SqlCeConnection con =
               new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string querySel2 = "SELECT QRCode FROM Reparacao where IDReparacao='" + dtnServico.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCeCommand cmd2 = new SqlCeCommand(querySel2, con);
            byte[] imgByteData = (byte[])cmd2.ExecuteScalar();
            Bitmap bitmap = new Bitmap(new MemoryStream(imgByteData));
            picQRCode.Image = bitmap;
            con.Close();
            btnExportarQRCode.Enabled = true;
            PassaDados.valor3 = dtnServico.CurrentRow.Cells[10].Value.ToString();
            PassaDados.valor = dtnServico.CurrentRow.Cells[2].Value.ToString();
            PassaDados.valor2 = dtnServico.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmConfig form = new frmConfig();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void painelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmServico_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmConfig form = new frmConfig();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void dtnServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
