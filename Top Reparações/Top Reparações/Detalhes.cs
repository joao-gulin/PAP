using FontAwesome.Sharp;
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
    public partial class Detalhes : Form
    {
        private IconButton btnAtual;
        string filtroDetalhes = "SELECT * FROM Detalhes order by FK_IDReparacao";
        private Form formAtual;
        public Detalhes()
        {
            InitializeComponent();
            btnAtual = new IconButton();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AbrirFormAtual(Form childForm)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            formAtual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painelDesktop.Controls.Add(childForm);
            painelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CarregaDataDetalhes()
        {
            SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            string query = filtroDetalhes;
            SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            con.Close();
        }

        private void FormataData()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Preço";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns["Preco"].DefaultCellStyle.Format = "N2";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AbrirFormAtual(new frmAdicionarDetalhes());
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza? Depois de concluido, não podera fazer alterações neste serviço!",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            double soma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                soma += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)
                    * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * 1.23;
            }
            

            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            con.Open();
            string query = "UPDATE Reparacao SET " +
                "Valor=@Valor," +
                "Estado=@Estado," +
                "Pago=@Pago " +
                " where IDReparacao=@IDReparacao";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@Valor", soma);
            cmd.Parameters.AddWithValue("@Estado", "Concluido");
            cmd.Parameters.AddWithValue("@Pago", "Sim");
            cmd.Parameters.AddWithValue("@IDReparacao", PassaDados.valor2);
            cmd.ExecuteScalar();
            MessageBox.Show("Serviço Concluido.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            frmServico form = new frmServico();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Detalhes_Activated(object sender, EventArgs e)
        {
            filtroDetalhes = "SELECT * FROM Detalhes where FK_IDReparacao=" + PassaDados.valor2;
            //if (PassaDados.valor3 == "Concluido" && PassaDados.valor3 == "Levantado")
            //{
            //    btnConcluir.Enabled = false;
            //    btnAdicionar.Enabled = false;
            //    btnEditar.Enabled = false;
            //    btnRemover.Enabled = false;
            //}
            //else
            //{
            //    btnAdicionar.Enabled = true;
            //    btnConcluir.Enabled = true;
            //    btnEditar.Enabled = true;
            //    btnRemover.Enabled = true;
            //}
            CarregaDataDetalhes();
            FormataData();
            materialLabel1.Text = "Total de registos: " +
                dataGridView1.RowCount.ToString();
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            materialLabel2.Text = "Total s/ IVA: " + sum.ToString();
            double IVA = 0;
            IVA = sum * 1.23;
            materialLabel3.Text = "Total c/ IVA: " + IVA.ToString();
            dataGridView1.ClearSelection();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void Detalhes_Leave(object sender, EventArgs e)
        {
            //double soma = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    soma += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)
            //        * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            //}

            //SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Top Reparacoes.sdf");
            //con.Open();
            //string query = "UPDATE Reparacao SET" +
            //    "Valor=@Valor " +
            //    " where IDReparacao=@IDReparacao";
            //SqlCeCommand cmd = new SqlCeCommand(query, con);
            //cmd.Parameters.AddWithValue("@Valor", soma);
            //cmd.Parameters.AddWithValue("@IDReparacao", txtIdServico.Text);
            //cmd.ExecuteScalar();
            //con.Close();
            //this.Close();
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            if (PassaDados.valor3 == "Concluido" && PassaDados.valor3 == "Levantado")
            {
                btnConcluir.Enabled = false;
                btnAdicionar.Enabled = false;
                btnEditar.Enabled = false;
                btnRemover.Enabled = false;
            }
            else
            {
                btnAdicionar.Enabled = true;
                btnConcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnRemover.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnRemover.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CarregaDataDetalhes();
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

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}