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
    public partial class LogoFarmacia : Form
    {

        //Form2 gh = new Form2();      
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public string user { get; set; }

        //private from activeForm; 


        public LogoFarmacia()

        {
            InitializeComponent();
            random = new Random();
            //btncloseChildForm.Visible = false;
            //this.Text = string.Empty();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void activateButton(object btnSender)
        {

        }
        //  if (btnsender != null)
        //  {
        //  if (currentButton != (Button) btnSender)
        //  {
        //  Color color = SelectThemeColor();
        //curruntButton= SelectThemeColor();
        //currentButton.BackColor=Color.White;
        //  currentButton.Font=new System.Drawing.Font( new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))););
        private void LogoFarmacia_Load(object sender, EventArgs e)
        {
           MessageBox.Show("Usuario "+user+ "Logado.");
        }

        private void PanelTitle1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();
            frmVendas.Location = new Point(197, 80);
            frmVendas.ShowDialog();          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btncadastro_Click(object sender, EventArgs e)
        {
            RegistoPaciente registoPaciente = new RegistoPaciente();
            registoPaciente.ShowDialog();
        }

        private void LogoFarmacia_LocationChanged(object sender, EventArgs e)
        {
            //label1.Text = this.Location.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo");
            MessageBox.Show("Bem vindo Este sismtema tem como propósito fazer controlo de farmácia e fazer comsultas de uma forma online.");
            MessageBox.Show("Bem vindo Este software tem como pricimpal objectivo organizar números de pacientes do um hospital");
         //   MessageBox.Show("Criadires Jose orlando Chilengue Tulio Benedito Nhatumbo Telis Eduardo Magaia ");
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {

        }
    }
}




