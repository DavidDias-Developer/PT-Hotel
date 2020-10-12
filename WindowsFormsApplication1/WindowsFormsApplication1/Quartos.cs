using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WindowsFormsApplication1
{
     
    public partial class Quartos : Form
    {
        int quant = 0;
        int num = 0;
        string id;
        Boolean quarto;
        string vago1;
        public static int menu;
        public static int getmenu
        {
            get { return menu; }
            set { menu = value; }
        }
        public static int corf;
        public static int getcorf
        {
            get { return corf; }
            set { corf = value; }
        }
        public Quartos()
        {
            InitializeComponent();
        }

        private void Quartos_Load(object sender, EventArgs e)
        {
            Principal.getprinc = 1;
            dataGridView1.DataSource = BLL.Clientes.Load4();
            textBox1.Enabled = false;
            if (corf == 2)
            {
                this.BackgroundImage = null;
            }
            if (corf == 1)
            {
                this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Quarotsadd2;
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Delete2;
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
            }
           
            dataGridView1.ReadOnly = true;
            label2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }
     

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Length < 1)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
            //*2
            if (textBox2.Text.Length < 1)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            //*3
            if (textBox3.Text.Length < 1)
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;

            }
            if (textBox8.Text.Length < 1)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            if (label8.Visible == true || label7.Visible == true || label2.Visible == true || label9.Visible == true)
            {
            }
            else
            {

                if (MessageBox.Show("Deseja Adicionar o Quarto", "Adicionar Quarto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    quant = Convert.ToInt32(textBox8.Text);
                do
                {
                    int retorno = BLL.Clientes.insertQuartos(true, comboBox1.Text, textBox2.Text, textBox3.Text);
                    quant = quant - 1;

                } while (quant != 0);
                dataGridView1.DataSource = BLL.Clientes.Load4();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox8.Text = "";
                comboBox1.SelectedIndex = -1;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            vago1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.QuartosLocked;
            pictureBox1.Enabled = false;
            
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.LoadQuartos(textBox7.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Principal.getprinc = 0;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Quarto2AddHover;
            }
            else
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Quartoshover;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Quarotsadd2;
            }
            else
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Quarotsadd;
            }
           
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Sair2hover;
            }
            else
            {
                 pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.SairHover;
            }
          
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
            }
            else
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Sair1;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(id);
            if (id2 != 0)
            {
                if (Convert.ToBoolean(vago1) == true)
                {
                    BLL.Clientes.deletequarto(id);
                    dataGridView1.DataSource = BLL.Clientes.Load4();
                }
                else
                {
                    MessageBox.Show("Este quarto encontra-se ocupado");
                }
              
            }
        }
           

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Delete2hover;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.DeleteHover;
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Delete2;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Delete1;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 8 && (int)e.KeyChar < 48 && (int)e.KeyChar != 44 || (int)e.KeyChar > 57 && (int)e.KeyChar != 44)
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
