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
    public partial class Base1 : Form
    {
        public Base1()
        {
            InitializeComponent();
        }

        private void Base1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.Load();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string num = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Reservas.getid1 = (Convert.ToString(num));
            this.Close();
        }

        private void Base1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Base1_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
