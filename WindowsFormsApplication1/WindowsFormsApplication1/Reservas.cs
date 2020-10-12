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
    public partial class Reservas : Form
    { string getpreco;
        double final;
        int id;
        int qt;
        int pt;
        string id4;
        int check;
        int cond;
        public static string id1;
        public static string getid1
       
        {
        get {return id1;}
        set {id1 = value;}
        }
        public static string id2;
        public static string getid2
          {
              get { return id2; }
              set { id2 = value; }
          }
        public static string pr;
        public static string getpr
        {
            get { return pr; }
            set { pr = value; }
        }
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
        public Reservas()

        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            Principal.getprinc = 1;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.ShowUpDown = true;
            textBox1.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox7.Enabled = false;
            textBox5.Text = "0";
            textBox4.Text = "0";
            textBox7.Text = "0";
            dataGridView1.DataSource = BLL.Clientes.Load5();
            this.dataGridView1.Sort(this.dataGridView1.Columns["Ativo"], ListSortDirection.Descending);
            pictureBox5.Enabled = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[10].Width = 125;
            label12.Visible = false;
            label13.Visible = false;
            textBox6.Enabled = false;
            if (corf == 2)
            {
                this.BackgroundImage = null;
            }
             if (corf == 1)
            {
                this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.reservaadd2;
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
            }
        }

        

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1)
            {
                label12.Visible = true;
            }
            else
            {
                label12.Visible = false;
            }
            if (textBox3.Text.Length < 1)
            {
                label13.Visible = true;
            }
            else
            {
                label13.Visible = false;
            }
            if (label12.Visible == true || label13.Visible == true)
            {
            }
            else
            {
                if (MessageBox.Show("Deseja Criar Esta Reserva?", "Adicionar Reserva?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    double quarto;
                    double rest;
                    double final;
                    id = Convert.ToInt32(textBox2.Text);
                    qt = Convert.ToInt32(textBox3.Text);
                    quarto = Convert.ToDouble(textBox5.Text);
                    rest = Convert.ToDouble(textBox4.Text);
                    final = Convert.ToDouble(textBox7.Text);
                    BLL.Clientes.insertReserva(id, qt, dateTimePicker3.Value, dateTimePicker2.Value, quarto, rest, final, textBox8.Text, true);
                    string quartn = textBox3.Text + ",";
                    BLL.Clientes.updateResQua(textBox2.Text, quartn, "SIM");
                    BLL.Clientes.updateVago(textBox3.Text, false);
                    dataGridView1.DataSource = BLL.Clientes.Load5();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "0";
                    textBox4.Text = "0";
                    textBox7.Text = "0";
                    dateTimePicker2.Value = System.DateTime.Now;
                    dateTimePicker3.Value = System.DateTime.Now;
                    textBox8.Text = "";
                    id1 = null;
                    id2 = null;
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Base1 f1= new Base1();
            f1.Show();
            f1.Location = new Point(190, 190);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Base2 f2 = new Base2();
            f2.Show();
            f2.Location = new Point(190, 300);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id4 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker3.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox1.Text = Convert.ToString(id4);
            double preço1 = Convert.ToDouble(textBox5.Text);
            double preço2 = Convert.ToDouble(textBox4.Text);
            double preço3 = preço1 + preço2;
            textBox7.Text = Convert.ToString(preço3);
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.reservaaddlocked;
            pictureBox1.Enabled = false;
            pictureBox5.Enabled = true;
            if (corf == 1)
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservafin2;
            }
            else
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservafin;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Principal.getprinc = 0;
            this.Close();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = pr ;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.reservaadd2hover;
            }
            else
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.reservaaddhover;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.reservaadd2;
            }
            else
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.reservaadd;
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cond = Convert.ToInt32(id4);
            if (cond != 0)
            {
            }
            else
            {

                DateTime com = dateTimePicker3.Value;
                DateTime end = dateTimePicker2.Value;
                if (end < com)
                {
                    MessageBox.Show("A data que inseriou não é valida");
                    dateTimePicker2.Value = System.DateTime.Now;
                }
                else
                    if (end > com)
                {
                TimeSpan temp = end - com;
                int tempo = temp.Days;
                double quarto = Convert.ToDouble(textBox5.Text);
                double diferença = quarto * tempo;
                textBox5.Text = Convert.ToString(diferença);
                int prec = Convert.ToInt32(textBox4.Text);
               double prec1 = diferença + prec;
                textBox7.Text = Convert.ToString(prec1);
            }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Selecione uma Reserva");
            }
            else
            {
                double acabou = Convert.ToDouble(textBox7.Text);
                BLL.Clientes.updateconc(id4, acabou, false);

                BLL.Clientes.updateQtAtivo(textBox3.Text, true);
                dataGridView1.DataSource = BLL.Clientes.Load5();
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservafin2hover;
            }
            else
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservafinhover;
            }
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservafin2;
            }
            else
            {
                pictureBox5.Image = WindowsFormsApplication1.Properties.Resources.reservafin;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            check = Convert.ToInt32(id1);
            if (check != 0)
            {
                textBox2.Text = id1;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            check = Convert.ToInt32(id2);
            if (check != 0)
            {
                textBox3.Text = id2;
                textBox5.Text = pr;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Reserva")
            {
                dataGridView1.DataSource = BLL.Clientes.LoadReser(textBox9.Text);
            }
            else
                if (comboBox1.Text == "Quarto")
                {
                    dataGridView1.DataSource = BLL.Clientes.LoadQuartosReser(textBox9.Text);
                }
                else
                    if (comboBox1.Text == "Cliente")
                    {
                        dataGridView1.DataSource = BLL.Clientes.LoadClienteReser(textBox9.Text);
                    }
        
               
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
