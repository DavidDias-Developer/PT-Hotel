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

    public partial class Principal : Form
        
    {
        int men1 = 0;
        int trans = 0;
        int cor = 0;
        public static string x;
        public static string getx
      
        {
            get { return x; }
            set { x = value; }
        }
        public static int princ;
        public static int getprinc
        {
            get { return princ; }
            set { princ = value; }
        }
        public static int pos;
        public static int getpos
        {
            get { return pos; }
            set {pos = value; }
        }
        
        public Principal()
        {
            InitializeComponent();
          
        }


        public void enabledpick() {
            PictureBox1.Enabled = true;
        
        }
        //Abre os Clientes  
        public void PictureBox1_Click(object sender, EventArgs e)
        {
            
            men1 = getprinc;
            if (men1 == 0 )
            {
                Clientes f2 = new Clientes();
                f2.Owner = this;
                f2.Show();
                f2.MdiParent = this;
                f2.Location = new Point(0, 0);
            }
            else
            {

                MessageBox.Show("Já existe uma janela aberta");
        }
            men1 = 1;
            Clientes.getmenu = men1;
}
        //Termina a Sessão
        private void button1_Click(object sender, EventArgs e)
        {
            
            Login f3 = new Login();
            f3.Show();
            this.Close();

        }

        //Abre os Funcionários
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           men1 = getprinc;
            if (men1 == 0 )
            {
            Funcionários f4 = new Funcionários();
            f4.Show();
            f4.MdiParent = this;
            f4.Location = new Point(0, 0);
            }
            else
            {

                MessageBox.Show("Já existe uma janela aberta");
            }
            men1 = 1;
            Funcionários.getmenu = men1;
        }

        //Abre os Quartos
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
           men1 = getprinc;
            if (men1 == 0 )
            {

          
            Quartos f5 = new Quartos();
            f5.Show();
            f5.MdiParent = this;
            f5.Location = new Point(0, 0);
            }
            else
            {

                MessageBox.Show("Já existe uma janela aberta");
            }
            men1 = 1;
            Quartos.getmenu = men1;
           
        }

        //Abre o Restaurante
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            men1 = getprinc;
            if (men1 == 0 )
            {  
         
            Restaurante f6 = new Restaurante();
            f6.Show();
            f6.MdiParent = this;
            f6.Location = new Point(0, 0);
            }
            else
            {

                MessageBox.Show("Já existe uma janela aberta");
            }
            men1 = 1;
            Restaurante.getmenu = men1;
        }
        //Principal Load
        private void Menu_Load(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                pictureBox2.Enabled = false;
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioLocked;
            }
            getprinc = trans;
            IsMdiContainer = true;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox6.Width - 3, pictureBox6.Height -3 );
            Region rg = new Region(gp);
            pictureBox6.Region = rg;



            label6.Text = getx;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }
  //Hover's     
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (cor == 1)
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarto2;
            }
            else
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarots;
            }
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (cor == 1)
            {


                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Comida2Hover;
            }
            else
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.ComidaHover;
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        { if (cor == 1)
            {


                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Comida2;
            }
            else
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
            if (cor == 1)
            {


                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario2;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario1;
            }
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (cor == 1)
            {


                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario2Hover;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioHover;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (cor == 1)
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarto2Hover;
                
            }
            else
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.HoverQuarto;
            }
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (cor == 1)
            {


                PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente2Hover;
            }
            else
            {
                PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.ClienteHover;
            }
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (cor == 1)
            {


                PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente2;
            }
            else
            {
                PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente1;
            }
            
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            if (cor == 1)
            {


                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva2hover;
            }
            else
            {
               pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservahover;
            }
           
        }
        //Loading mais rápidos
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 
        
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (cor == 1)
            {


                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva2;
            }
            else
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva;
            }
           

        }
        //Abre as Reservas
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            men1 = getprinc;
            if (men1 == 0 )
            {  
           
            Reservas f7 = new Reservas();
            f7.Show();
            f7.MdiParent = this;
            f7.Location = new Point(0, 0);
            }
            else
            {

                MessageBox.Show("Já existe uma janela aberta");
            }
            men1 = 1;
            Reservas.getmenu = men1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }
        //Terminar Sessão
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Terminar a Sessão?", "Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login f1 = new Login();
                f1.Show();
                pos = 0;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

           //Abre o Manual     
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\David\\Desktop\\PT Hotel\\WindowsFormsApplication1\\WindowsFormsApplication1\\bin\\Debug\\Manual.pdf");
            
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.ManualHover;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.Manual;
        }

        private void Menu_StyleChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = WindowsFormsApplication1.Properties.Resources.Settings1;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = WindowsFormsApplication1.Properties.Resources.Settings;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox8, 0, pictureBox8.Height);
        }

        private void mudarACorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
//Muda Cor para Azul
        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                pictureBox2.Enabled = true;
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioLocked;
                pictureBox2.Enabled = false;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario2;
            }
            Clientes.corf = 1;
            Funcionários.corf = 1;
            Quartos.corf = 1;
            Reservas.corf = 1;
            Restaurante.corf = 1;
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
            cor = 1;
            pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarto2;
           
            PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente2;
            pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva2;
            pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Comida2;
            
        }
//Muda para Laranja
        private void laranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                pictureBox2.Enabled = true;
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioLocked;
                pictureBox2.Enabled = false;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario1;
            }
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background;
            cor = 0;
            pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarots;
            PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente1;
            pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva;
            pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Comida1;
            Clientes.corf = 0;
            Funcionários.corf = 0;
            Quartos.corf = 0;
            Reservas.corf = 0;
            Restaurante.corf = 0;
            
        }

        private void cinzentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                pictureBox2.Enabled = true;
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.FuncionarioLocked;
                pictureBox2.Enabled = false;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Funcionario1;
            }
            this.BackgroundImage = null;
            cor = 2;
            pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.Quarots;
            PictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Cliente1;
            pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reserva;
            pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Comida1;
            Clientes.corf = 2;
            Funcionários.corf = 2;
            Quartos.corf = 2;
            Reservas.corf = 2;
            Restaurante.corf = 2;
        }

    }
}
