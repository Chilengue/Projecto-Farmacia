using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacia_Pequeno_Resgisto
{
    public partial class frmVendas : Form
    {
        string path = @"Data Source=CHILENGUE\JOSE_SERVER; Initial Catalog=Gest_Farmacia;Integrated Security=True";
        //caminho da base de dados  usando sqll setve do Microssoft criano caminho da base de dados com, ligacoa co selq server  c da mirscofft 
        //
        SqlConnection con;
        SqlCommand cmd;

        public frmVendas()
        {
            // Base de conexao da base de dados em SQL Server 
            con = new SqlConnection(path);
            InitializeComponent();
        }

            private void GroupBox1_Enter(object sender, EventArgs e)
            {
                        
            }

            private void TextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void Label2_Click(object sender, EventArgs e)
            {

            }

            private void Button3_Click(object sender, EventArgs e)
            {

            }

        private void Confirmar_Click(object sender, EventArgs e)
        {
           if(txtCodCliente.Text== "" || txtNomeCliente.Text==""|| txtCodgoFuncionario.Text=="" || txtFuncionario.Text==""|| txtCodigoProduto.Text==""|| txtProduto.Text==""|| txtQuantidade.Text=="" || txtUnitario.Text=="")
            {
                MessageBox.Show("Encontrado ");
            }
           else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert into   Gest_Farmacia(Codigo_Cliente,Nome_clente," +
                        "Nome_Funcionario,Codigo_produto,Nome_Produto,QtProduto,preco_unitario," +
                        "QtProduto,preco_unitario)Values ('" + txtCodCliente.Text + "','" + txtNomeCliente.Text + "'," +
                        "'" + txtCodgoFuncionario.Text + "','" + txtFuncionario.Text + "','" + txtCodigoProduto.Text + "'," +
                        "'" + txtProduto.Text + "','" + txtQuantidade.Text + "','" + txtUnitario.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Minizar_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnMinizar_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minizarcintaxe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnValorTot_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdicinar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("1", txtNomeCliente.Text, txtProduto.Text, txtQuantidade.Text, txtUnitario.Text);             
        }

        private void Btnvendas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void TxtFuncionario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
