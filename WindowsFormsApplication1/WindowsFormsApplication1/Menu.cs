using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Menu : Form
        
    {
        public static string x;
        public static string getx
        {
            get { return x; }
            set { x = value; }
        }
        public Menu()
        {
            InitializeComponent();
          
        }


        public void enabledpick() {
            PictureBox1.Enabled = true;
        
        }
        //Clientes
        public void PictureBox1_Click(object sender, EventArgs e)
        { 
          
            PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.ClienteLocked; 
            PictureBox1.Enabled = false;
            Clientes f2 = new Clientes();
            f2.Show();
            f2.MdiParent = this;
            f2.Location = new Point(0, 0);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Login f3 = new Login();
            f3.Show();
            this.Close();

        }

        //Funcionários
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioLocked; 
            pictureBox2.Enabled = false;
            Funcionários f4 = new Funcionários();
            f4.Show();
            f4.MdiParent = this;
            f4.Location = new Point(0, 0);
            
        }

        //Quartos
        private void pictureBox3_Click(object sender, EventArgs e)
        {


            pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.QuartosLocked;
            pictureBox3.Enabled = false;
            Quartos f5 = new Quartos();
            f5.Show();
            f5.MdiParent = this;
            f5.Location = new Point(0, 0);
          
        }

        //Restaurante
        private void pictureBox4_Click(object sender, EventArgs e)
        {
             
            pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.ComidaLocked;
            pictureBox4.Enabled = false;
            Restaurante f6 = new Restaurante();
            f6.Show();
            f6.MdiParent = this;
            f6.Location = new Point(0, 0);
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox6.Width - 3, pictureBox6.Height -3 );
            Region rg = new Region(gp);
            pictureBox6.Region = rg;
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }
        public void ValueFromForm1(string value)
        {
            label6.Text = value;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox3.Enabled == true)
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarots;
            }
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.ComidaHover;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox4.Enabled == true)
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Comida1;
            }
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox2.Enabled == true)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario1;
            }
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioHover;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.HoverQuarto;
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.ClienteHover;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (PictureBox1.Enabled == true)
            {

                PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente1;
            }
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservahover;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox5.Enabled == true)
            {

                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva;
            }

        }
        //Login
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservalocked;
            pictureBox5.Enabled = false;
            Reservas f7 = new Reservas();
            f7.Show();
            f7.MdiParent = this;
            f7.Location = new Point(0, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Terminar a Sessão?", "Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login f1 = new Login();
                f1.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

                
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\109365\\Desktop\\PT Hotel\\WindowsFormsApplication1\\WindowsFormsApplication1\\bin\\Debug\\Manual de Instruções.docx");
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.ManualHover;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.Manual;
        }\\

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = WindowsFormsApplication1.Properties.Resources.Settings1;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = WindowsFormsApplication1.Properties.Resources.Settings;
        }

    }
}
