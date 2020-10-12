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
using System.Security.Cryptography;
using System.IO;
using DataAccessLayer;

namespace WindowsFormsApplication1
{
    public partial class Funcionários : Form
    {
        string id;
        string id2;
        int but;
        Boolean m1;
        Boolean log;
        Image img;
        byte[] bArr;
        string email;
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

        public Funcionários()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        //Atualizar Funcionário
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrador")
            {
                m1 = true;
            }
            else
            {
                m1 = false;
            }
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
            if (textBox4.Text.Length < 21)
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            //*5
            if (textBox5.Text.Length < 9)
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            //*6   
            if (comboBox1.Text.Length < 1)
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
            if (comboBox2.Text.Length < 1)
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
            if (textBox10.Text.Length < 1)
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }


            if (pictureBox1.Image == null)
            {
                label21.Visible = true;
            }   
            else
            {
                label21.Visible = false;
            }



            if (label8.Visible == true || label16.Visible == true || label9.Visible == true || label10.Visible == true || label14.Visible == true || label15.Visible == true || label17.Visible == true || label18.Visible == true || label21.Visible == true)
            {
            }
            else
            {
                DataTable validarnif2 = BLL.Clientes.validarNIF2(Convert.ToInt32(id), textBox5.Text);
                if (validarnif2.Rows.Count == 0)
                {
                    if (MessageBox.Show("Deseja atualizar o Funcionário?", "Atualizar Funcionário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        BLL.Clientes.updateFuncionario(id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, textBox10.Text, textBox10.Text, m1);
                        dataGridView1.DataSource = BLL.Clientes.Load2();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        pictureBox1.Image = null;
                        textBox10.Clear();
                        textBox7.Clear();
                        pictureBox3.Enabled = false;
                        pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizarlocked;
                        pictureBox2.Enabled = true;
                        if (corf == 1)
                        {
                            pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.add2;
                        }
                        else
                        {
                            pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.add;
                        }
                        MessageBox.Show("Atualizado com sucesso!");

                    }
                }
                else
                {
                    MessageBox.Show("Este Nif já existe");
                }
            }
        }
        //Sair
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Principal.getprinc = 0;
            but = 1;
            Principal.getx = (Convert.ToString(but));
            this.Close();

        }

        private void Funcionários_Load(object sender, EventArgs e)
        {
            Principal.getprinc = 1;
            dataGridView1.DataSource = BLL.Clientes.Load2();

            pictureBox3.Enabled = false;
            dataGridView1.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 230;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 145;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[6].Width = 135;
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].Width = 128;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;
          
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label21.Visible = false;
            label16.Visible = false;
            if (corf == 2)
            {
                this.BackgroundImage = null;
                tabPage1.BackgroundImage = null;
            }
            if (corf == 1)
            {
                this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
                tabPage1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background2;
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.add2;
                pictureBox4.Image = WindowsFormsApplication1.Properties.Resources.Sair2;
            }
        }




        //Adicionar Funcionário
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Administrador")
            {
                m1 = true;
            }
            else
            {
                m1 = false;
            }
            //Labels visíveis ou não *1
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
            if (textBox4.Text.Length < 21)
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            //*5
            if (textBox5.Text.Length < 9)
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            //*6   
            if (comboBox1.Text.Length < 1)
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
            if (comboBox2.Text.Length < 1)
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
            if (textBox10.Text.Length < 1)
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }


            if (pictureBox1.Image == null)
            {
                label21.Visible = true;
            }
            else
            {
                label21.Visible = false;
            }



            if (label8.Visible == true || label16.Visible == true || label9.Visible == true || label10.Visible == true || label14.Visible == true || label15.Visible == true || label17.Visible == true || label18.Visible == true || label21.Visible == true)
            {
            }
            else
            {
                DataTable validarnif = BLL.Clientes.validarNIF(textBox5.Text);
                DataTable validarconta = BLL.Clientes.validarConta(textBox10.Text);
                if (validarnif.Rows.Count == 0)
                {
                    if (validarconta.Rows.Count > 0)
                    {
                        MessageBox.Show("Esta conta já existe");
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja adicionar funcionário?", "Adicionar funcionário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {



                            log = true;
                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, pictureBox3.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            string pass1 = "12345";
                            int retorno = BLL.Clientes.insertFuncionarios(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, comboBox1.Text, comboBox2.Text, textBox10.Text, pass1, m1, log, textBox7.Text, img);
                            dataGridView1.DataSource = BLL.Clientes.Load2();
                            MessageBox.Show("Funcionário Adicionado");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox10.Clear();
                            textBox5.Clear();
                            comboBox1.SelectedIndex = -1;
                            comboBox2.SelectedIndex = -1;
                            pictureBox1.Image = null;
                            textBox7.Clear();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este Nif já existe");
                }
            }
        }  
                
            
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mstream = new MemoryStream())
            {
                img.Save(mstream, img.RawFormat);
                return mstream.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
            
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
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells[13].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.addlocked;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            comboBox2.Enabled = true;
            textBox10.Enabled = false;
            var = 1;
            pictureBox2.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.LoadFunc(textBox6.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        //Adicionar Conta
        private void pictureBox7_Click(object sender, EventArgs e)
        {




        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.add2hover;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.addhover;
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.add2;
            }
            else
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.add;
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

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {

        }


        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // abre o filedialog
            DialogResult result = openFileDialog1.ShowDialog();
             if (result == DialogResult.OK)
            {

                string file = openFileDialog1.FileName.ToString();
                img = Image.FromFile(file, true);
                pictureBox1.Image = img;
                bArr = imgToByteArray(img);
                img = byteArrayToImage(bArr);
                pictureBox1.Image = img;

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                var = 0;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2hover;
            }
            else
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizarhover;
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (corf == 1)
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
            }
            else
            {
                pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (var == 1)
            {
                pictureBox3.Enabled = true;
                if (corf == 1)
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar2;
                }
                else
                {
                    pictureBox3.Image = WindowsFormsApplication1.Properties.Resources.atualizar;
                }
            }
        }

    }
}