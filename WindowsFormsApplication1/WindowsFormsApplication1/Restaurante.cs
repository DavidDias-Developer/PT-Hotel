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
    public partial class Restaurante : Form

    {

        double preço;
        double preço2;
        double preço3;
        double preço4;
        double preço5;
        double preçof;
        string produtos;
        string rem;
        string getpreço;
        int unlock;
        int quantidades;
        string id;
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
        public Restaurante()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            preço += 7.50;
            label18.Text = preço.ToString();
            listBox1.Items.Add("Pequeno-almoço Romantico");
            preçof += 7.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Pequeno-almoço Romantico");
            unlock = 1;
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            preço += 4.00;
            label18.Text = preço.ToString();
            listBox1.Items.Add("Pequeno-almoço Simples");
            preçof += 4.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Pequeno-almoço Simples");

            unlock = 1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            preço2 += 9.00;
            label24.Text = preço2.ToString();
            listBox6.Items.Add("Menu do Mar");
            preçof += 9.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Menu do Mar");
            unlock = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            preço2 += 7.50;
            label24.Text = preço2.ToString();
            listBox6.Items.Add("Menu Bitoque");
            preçof += 7.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Menu Bitoque");
            unlock = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            preço2 += 10.00;
            label24.Text = preço2.ToString();
            listBox6.Items.Add("Menu Bacalhau");
            preçof += 10.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Menu Bacalhau");

            unlock = 1;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            preço2 += 2.50;
            label24.Text = preço2.ToString();
            listBox6.Items.Add("Doce de Fruta");
            preçof += 2.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Doce de Fruta");
            unlock = 1;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            preço2 += 2.00;
            label24.Text = preço2.ToString();
            listBox6.Items.Add("Bolo de Chocolate");
            preçof += 2.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Bolo de Chocolate");

            unlock = 1;
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            preço2 += 2.50;
            label24.Text = preço2.ToString();
            listBox6.Items.Add("Parfait");
            preçof += 2.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Parfait");
            unlock = 1;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            preço3 += 5.00;
            label44.Text = preço3.ToString();
            listBox4.Items.Add("Lanche Clássico");
            preçof += 5.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Lanche Clássico");

            unlock = 1;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            preço3 += 3.00;
            label44.Text = preço3.ToString();
            listBox4.Items.Add("Sandes de Verão");
            preçof += 3.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Sandes de Verão");

            unlock = 1;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            preço3 += 4.00;
            label44.Text = preço3.ToString();
            listBox4.Items.Add("Waffers");
            preçof += 4.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Waffers");

            unlock = 1;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            preço4 += 7.99;
            label41.Text = preço4.ToString();
            listBox2.Items.Add("Frango da Noite");
            preçof += 7.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Frango da Noite");

            unlock = 1;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            preço4 += 8.99;
            label41.Text = preço4.ToString();
            listBox2.Items.Add("Bacalhau da Terra");
            preçof += 8.99;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Bacalhau da Terra");

            unlock = 1;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            preço4 += 10.00;
            label41.Text = preço4.ToString();
            listBox2.Items.Add("Camaron");
            preçof += 10.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Camaron");

            unlock = 1;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            preço4 += 2.50;
            label41.Text = preço4.ToString();
            listBox2.Items.Add("Moranguinho");
            preçof += 2.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Moranguinho");

            unlock = 1;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            preço4 += 2.00;
            label41.Text = preço4.ToString();
            listBox2.Items.Add("Semifrio de Ananás");
            preçof += 2.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Semifrio de Ananás");

            unlock = 1;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            preço4 += 1.00;
            label41.Text = preço4.ToString();
            listBox2.Items.Add("Fruta");
            preçof += 1.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Fruta");

            unlock = 1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            preço5 += 1.50;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Refrigerantes");
            preçof += 1.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Refrigerantes");

            unlock = 1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            preço5 += 1.00;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Àgua");
            preçof += 1.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Àgua");

            unlock = 1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            preço5 += 7.00;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Vinho Tinto");
            preçof += 7.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Vinho Tinto");
            unlock = 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            preço5 += 7.00;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Vinho Branco");
            preçof += 7.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Vinho Branco");
            unlock = 1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            preço5 += 0.70;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Pão");
            preçof += 0.70;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Pão");
            unlock = 1;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            preço5 += 1.50;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Sopa");
            preçof += 1.50;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Sopa");
            unlock = 1;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            preço5 += 2.00;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Entrada");
            preçof += 2.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Entrada");
            unlock = 1;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            preço5 += 2.00;
            label47.Text = preço5.ToString();
            listBox3.Items.Add("Queijo");
            preçof += 2.00;
            label71.Text = preçof.ToString();
            listBox5.Items.Add("Queijo");

            unlock = 1;
        }

        private void Restaurante_Load(object sender, EventArgs e)
        {
            Principal.getprinc = 1;
            dataGridView1.DataSource = BLL.Clientes.Load5();
            pictureBox24.Image = WindowsFormsApplication1.Properties.Resources.DeleteLocked;
          if (listBox5.SelectedItems.Count == 0)
            {
                pictureBox24.Enabled = false;
               
            }
          if (corf == 2)
          {
              this.BackgroundImage = null;
              tabPage1.BackgroundImage = null;
              tabPage2.BackgroundImage = null;
              tabPage3.BackgroundImage = null;
              tabPage4.BackgroundImage = null;
              tabPage5.BackgroundImage = null;
              tabPage6.BackgroundImage = null;

          }
          if (corf == 1)
          {
              this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              tabPage1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              tabPage2.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              tabPage3.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              tabPage4.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              tabPage5.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              tabPage6.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
              pictureBox24.Image = WindowsFormsApplication1.Properties.Resources.Delete2;
              pictureBox25.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
          }         
          pictureBox28.Enabled = false;
       
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {  
           
            while (listBox5.SelectedItems.Count != 0)
            {
                
                rem = (listBox5.SelectedIndex.ToString());
                listBox5.Items.Remove(listBox5.SelectedItems[0]);
                
                if (listBox4.Items.ToString().Contains(rem))
                {
                    listBox4.Items.Remove(rem);
                }
                
            }

                 
            pictureBox24.Image = WindowsFormsApplication1.Properties.Resources.DeleteLocked;
           
            pictureBox24.Enabled = false;
           
           

          
        }

        private void pictureBox24_MouseEnter(object sender, EventArgs e)
        {
            pictureBox24.Image = WindowsFormsApplication1.Properties.Resources.DeleteHover;
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
        


            pictureBox24.Image = WindowsFormsApplication1.Properties.Resources.Delete1;
        }

        private void listBox5_MouseClick(object sender, MouseEventArgs e)
        {
            
                pictureBox24.Enabled = true;
                pictureBox24.Image = WindowsFormsApplication1.Properties.Resources.Delete1;



            
        }

        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
           
           
            
          
        }

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar o Pedido?", "Finalizar Pedido?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                double mon;
                quantidades = listBox5.Items.Count;
                string allItems = "";
                foreach (string item in listBox5.Items)
                {
                    allItems += item + ",";
                }
                produtos = listBox5.Text;
                mon = Convert.ToDouble(label71.Text);
                int retorno = BLL.Clientes.insertRestaurante(allItems, quantidades, mon);
                BLL.Clientes.updateResCom(id, allItems, mon);
                listBox5.Items.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                label71.Text = null;
                dataGridView1.DataSource = BLL.Clientes.Load5();
            }
        }

        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {
            pictureBox28.Image = WindowsFormsApplication1.Properties.Resources.okhover;
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            pictureBox28.Image = WindowsFormsApplication1.Properties.Resources.ok;
        }

        private void pictureBox28_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Principal.getprinc = 0;
            this.Close();
        }

        private void pictureBox25_MouseEnter(object sender, EventArgs e)
        {
            pictureBox25.Image = WindowsFormsApplication1.Properties.Resources.SairHover;
        }

        private void pictureBox25_MouseLeave(object sender, EventArgs e)
        {
            pictureBox25.Image = WindowsFormsApplication1.Properties.Resources.Sair1;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            {
                if (unlock == 1)
                {
                    pictureBox28.Enabled = true;
                    
                        pictureBox28.Image = WindowsFormsApplication1.Properties.Resources.ok;
                    

                }
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.LoadReser(textBox1.Text);
        }
    }
}
