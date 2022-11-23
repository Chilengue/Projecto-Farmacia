using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Data.SqlClient;

namespace Farmacia_Pequeno_Resgisto
{
    public partial class RegistoPaciente : Form
    {
        
        string path = @"Data Source=CHILENGUE\JOSE_SERVER; Initial Catalog=Gest_Farmacia;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        private object txtNacionalidade;

        public RegistoPaciente()
        {
            InitializeComponent();
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add("1", txtNome.Text, txtTelefone.Text, txtTelefone2.Text, txtBairro.Text,
                txtSexo, txtEndereco.Text, txtEmail.Text, txtCelular, txtCodigo.Text, txtnacionalidade.Text, txtEstadoCivil);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (txtnacionalidade.Text == "" || txtTelefone.Text == "" || txtTelefone2.Text == "" || txtBairro.Text == "" ||
                txtSexo.Text == "" || txtEndereco.Text == "" || txtEmail.Text == "" || txtCelular.Text == ""
                || txtCodigo.Text == "" || txtNacionalidade.Text == "" || txtEstadoCivil = "")
            {
                MessageBox.Show("Encontrado ");
            }
            else
            {
                try
                {
                    string Sexo;
                    if (rbtHomem.Checked)
                    {
                        Sexo = "Homem";
                    }
                    else
                    {
                        Sexo = "Mulher";
                    }
                    string Estadocivil;
                    if (rbtCasado.Checked)
                    {

                    }
                    if (rbtSolteiro.Checked)
                    {

                    }
                    if (rbtViuvo.Checked)
                    {

                    }
                    con.Open();
                    /*   cmd = new SqlCommand("insert into   Gest_Farmacia(Codigo_Cliente,Nome_clente," +
                            "Nome_Funcionario,Codigo_produto,Nome_Produto,QtProduto,preco_unitario," +
                            "QtProduto,preco_unitario)Values ('" + txtCodCliente.Text + "','" + txtNomeCliente.Text + "'," +
                            "'" + txtCodgoFuncionario.Text + "','" + txtFuncionario.Text + "','" + txtCodigoProduto.Text + "'," +
                            "'" + txtProduto.Text + "','" + txtQuantidade.Text + "','" + txtUnitario.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close(); }*/
                }
                catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
           

                }

        private void ExitProgramacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minizarcintaxe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinMazGrand_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
     
        }
    } }

  