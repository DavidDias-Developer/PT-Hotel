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
    public partial class Base2 : Form
    {
        public Base2()
        {
            InitializeComponent();
        }

        private void Base2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.Load4();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            
            Boolean vago = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (vago == false)
            {
                MessageBox.Show("Este Quarto já se encontra ocupado");
            }
            else
            {
                string num = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Reservas.pr = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Reservas.getid2 = (Convert.ToString(num));
               
                this.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void Base2_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
