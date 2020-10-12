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
    public partial class LoginNovo : Form
    {
        public static string user;
        public static string getuser
    {
        get {return user;}
        set {user = value;}
        
     }
        public static int pos1;
        public static int getpos1
        {
            get { return pos1; }
            set { pos1 = value; }

        }
        public LoginNovo()
        {
            InitializeComponent();
        }

        private void LoginNovo_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("As palavras-passe não coincidem");
            }
            else if (pos1 == 1)
            {
                Principal.pos = 1;
            
            BLL.Clientes.updateLogin(user,textBox2.Text,false);
            Principal f1 = new Principal();
            f1.ShowDialog();
            this.Close();
            }
        }
    }
}
