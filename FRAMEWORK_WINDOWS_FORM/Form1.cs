using FRAMEWORK_WINDOWS_FORM.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRAMEWORK_WINDOWS_FORM
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }


        private List<Usuario> cargaUsuarios()
        {
            using (crud_mvcEntities db = new crud_mvcEntities())
            {
                return db.Usuario.ToList();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DatosBd.DataSource = cargaUsuarios();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
