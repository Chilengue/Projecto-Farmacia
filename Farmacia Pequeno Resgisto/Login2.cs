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
using System.Security.Cryptography;
using System.Text;
using System;

namespace Farmacia_Pequeno_Resgisto
{
    public partial class Login2 : Form
    {
        SqlConnection con =new  SqlConnection ("Data Source=CG\JOSE_SERVER; Initial Catalog=Gest_Farmacia;Integrated Security=True");
       // SqlConnection con =new  SqlConnection ("Data Source=; Initial Catalog=Gest_Farmacia;Integrated Security=True");
        public Login2()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           try
            {
                if(txtUsername.Text=="" && txtPassword.Text=="")
                {
                   
                }
                else
                {
                    SqlConnection sqlConnection = null;
                    SqlCommand cmd = null;
                    SqlDataReader dataReader = null;
                    sqlConnection = new SqlConnection(@"Data Source=CG\JOSE_SERVER;Initial Catalog=Gest_Farmacia;Integrated Security=True");
                    sqlConnection.Open();
                    string SQL = "Select * From Login2 Where U_Name like '" + txtUsername.Text+"' and U_Pass like '"+txtPassword.Text+"'";
                    cmd = new SqlCommand(SQL, sqlConnection);
                    dataReader = cmd.ExecuteReader();
                   if(dataReader.Read())
                    {
                         LogoFarmacia bc = new LogoFarmacia();
                        bc.user = txtUsername.Text;
                        this.Hide(); 
                        bc.Show();
                    }
                   else
                    {
                        MessageBox.Show("Verfica seu User name ou Password ");
                    }
                         
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
