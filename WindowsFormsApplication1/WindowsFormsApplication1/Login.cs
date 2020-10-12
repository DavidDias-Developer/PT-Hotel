using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WindowsFormsApplication1
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Botão de LOGIN
        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable Data = BLL.Clientes.Sessao.login(TextBox1.Text, TextBox2.Text);
            if (Data.Rows.Count > 0)
            {
                if (Convert.ToBoolean(Data.Rows[0][11]))
                {
                    Principal.getx = TextBox1.Text;
                    LoginNovo.getuser = (Convert.ToString(Data.Rows[0][0]));
                    LoginNovo.pos1 = 1;
                    this.Close();
                    LoginNovo f4 = new LoginNovo();
                    f4.ShowDialog();
                }
                else
                    if (Data.Rows.Count > 0)
                    {
                        if (Convert.ToBoolean(Data.Rows[0][10]))
                        {
                            Principal.getx = TextBox1.Text;
                            WindowsFormsApplication1.Principal.getx = TextBox1.Text;
                            this.Hide();
                            Principal f2 = new Principal();
                            f2.ShowDialog();
                        }
                        else
                        {
                            Principal.getx = TextBox1.Text;
                            Principal.pos = 1;
                            this.Hide();
                            Principal f2 = new Principal();
                            f2.ShowDialog();
                        }
                    }
            }
            else
            {
                MessageBox.Show("Utilizador ou Palavra-Passe Incorrecto");
            }
        }

        //LOGIN (ENTER)
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataTable Data = BLL.Clientes.Sessao.login(TextBox1.Text, TextBox2.Text);
                if (Data.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(Data.Rows[0][11]))
                    {
                        Principal.getx = TextBox1.Text;
                        LoginNovo.getuser = (Convert.ToString(Data.Rows[0][0]));
                        LoginNovo.pos1 = 1;
                        this.Close();
                        LoginNovo f4 = new LoginNovo();
                        f4.ShowDialog();
                    }
                    else
                        if (Data.Rows.Count > 0)
                        {
                            if (Convert.ToBoolean(Data.Rows[0][10]))
                            {
                                Principal.getx = TextBox1.Text;
                                WindowsFormsApplication1.Principal.getx = TextBox1.Text;
                                this.Hide();
                                Principal f2 = new Principal();
                                f2.ShowDialog();
                            }
                            else
                            {
                                Principal.getx = TextBox1.Text;
                                Principal.pos = 1;
                                this.Hide();
                                Principal f2 = new Principal();
                                f2.ShowDialog();
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Utilizador ou Palavra-Passe Incorrecto");
                }
            }
        }
        //Botão de sair da aplicação
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataTable Data = BLL.Clientes.Sessao.login(TextBox1.Text, TextBox2.Text);
                if (Data.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(Data.Rows[0][11]))
                    {
                        Principal.getx = TextBox1.Text;
                        LoginNovo.getuser = (Convert.ToString(Data.Rows[0][0]));
                        LoginNovo.pos1 = 1;
                        this.Close();
                        LoginNovo f4 = new LoginNovo();
                        f4.ShowDialog();
                    }
                    else
                        if (Data.Rows.Count > 0)
                        {
                            if (Convert.ToBoolean(Data.Rows[0][10]))
                            {
                                Principal.getx = TextBox1.Text;
                                WindowsFormsApplication1.Principal.getx = TextBox1.Text;
                                this.Hide();
                                Principal f2 = new Principal();
                                f2.ShowDialog();
                            }
                            else
                            {
                                Principal.getx = TextBox1.Text;
                                Principal.pos = 1;
                                this.Hide();
                                Principal f2 = new Principal();
                                f2.ShowDialog();
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Utilizador ou Palavra-Passe Incorrecto");
                }
            }
        }
    }
}