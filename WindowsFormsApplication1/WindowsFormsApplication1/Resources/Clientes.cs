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
    public partial class Clientes : Form
    {

        string id;
        string menu1;
        int var;
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

        public Clientes()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Principal.getprinc = 1;
            dataGridView1.DataSource = BLL.Clientes.Load();
            pictureBox7.Enabled = false;
            dataGridView1.AutoSizeRowsMode =
         DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 230;
            dataGridView1.Columns[2].Width = 230;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 210;
            dataGridView1.Columns[8].Width = 220;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            if (corf == 2)
            {
                this.BackgroundImage = null;
            }
            if (corf == 1)
            {
                this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.add2;
                pictureBox6.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.LoadNome(textBox7.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        //Adicionar Cliente
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
            //*2
            if (textBox2.Text.Length < 1)
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
            //*3
            if (textBox3.Text.Length < 12)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            //*4    
            if (textBox4.Text.Length < 9)
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            //*5  
            if (comboBox1.Text.Length < 1)
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            if (label8.Visible == true || label9.Visible == true || label10.Visible == true || label14.Visible == true || label8.Visible == true)
            {
            }
            else
            {
                DataTable validarnif = BLL.Clientes.validarNIFCliente(textBox4.Text);
                if (validarnif.Rows.Count == 0)
                {
                    if (MessageBox.Show("Deseja adicionar cliente?", "Adicionar cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int retorno = BLL.Clientes.insertCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Text, textBox6.Text, comboBox1.Text);
                        dataGridView1.DataSource = BLL.Clientes.Load();
                        MessageBox.Show("Cliente Adicionado");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        comboBox1.SelectedIndex = -1;
                        dateTimePicker1.Value = System.DateTime.Now;
                    }
                }
                else
                {
                    MessageBox.Show("Este Nif já existe");
                }
            }
        }
        //Atualizar Cliente
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
            //*2
            if (textBox2.Text.Length < 1)
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
            //*3
            if (textBox3.Text.Length < 12)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            //*4    
            if (textBox4.Text.Length < 9)
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            //*5  
            if (comboBox1.Text.Length < 1)
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            if (label8.Visible == true || label9.Visible == true || label10.Visible == true || label14.Visible == true || label8.Visible == true)
            {
            }
            else
            {
                if (MessageBox.Show("Deseja atualizar cliente?", "Atualizar cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLL.Clientes.updateCliente(id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text);
                    dataGridView1.DataSource = BLL.Clientes.Load();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    comboBox1.Text = "";
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizarlocked;
                    pictureBox7.Enabled = false;
                    pictureBox4.Enabled = true;
                    pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.add;
                    MessageBox.Show("Atualizado com sucesso!");
                }
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            var = 1;
            pictureBox4.Enabled = false;
            pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.addlocked;

        }

        //Sair Cliente
        public void pictureBox6_Click(object sender, EventArgs e)
        {
            Principal.getprinc = 0;
            getmenu = 0;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.add2hover;
            }
            else
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.addhover;
            }
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.add2;
            }
            else
            {
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.add;

            }
        }


        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox6.Image = WindowsFormsApplication1.Properties.Resources.Sair2hover;
            }
            else
            {
                pictureBox6.Image = WindowsFormsApplication1.Properties.Resources.SairHover;
            }
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox6.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
            }
            else
            {
                pictureBox6.Image = WindowsFormsApplication1.Properties.Resources.Sair1;
            }
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2hover;
            }
            else
            {
                pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizarhover;
            }
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
            }
            else
            {
                pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void Clientes_Enter(object sender, EventArgs e)
        {

        }

        private void Clientes_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox7.Enabled = true;

                if (corf == 1)
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox7.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 8 && (int)e.KeyChar < 48 && (int)e.KeyChar != 44 || (int)e.KeyChar > 57 && (int)e.KeyChar != 44)
                e.Handled = true;
        }
    }
}
       
        
    

