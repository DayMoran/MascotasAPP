using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotasAPP
{
    public partial class FormRopa : Form
    {
        BindingList<Ropa> milista;
        public FormRopa()
        {
            
            InitializeComponent();
            //Importante inicializar la lista
            milista = new BindingList<Ropa>();
            dataGridView1.DataSource = milista;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Ropa p = new Ropa(txt_nombre.Text, txt_marca.Text,decimal.Parse(mtxt_precio.Text),cbo_talla.SelectedItem.ToString(), chk_disponible.Checked);
            MessageBox.Show("Articulo agregado: \n"+p.ToString());

            milista.Add(p);
        }

        private void FormRopa_Load(object sender, EventArgs e)
        {
            cbo_talla.SelectedIndex = 0;
        }
    }
}
