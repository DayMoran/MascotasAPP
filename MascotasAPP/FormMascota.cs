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
    public partial class FormMascota : Form
    {
        BindingList<Mascota> milista;
        public FormMascota()
        {
            
            InitializeComponent();
            milista = new BindingList<Mascota>();
            dataGridView1.DataSource = milista;
        }

        private void FormMascota_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Mascota mimascota = new Mascota(txt_nombre.Text, txt_especie.Text, decimal.Parse(mtxt_edad.Text),decimal.Parse(mtxt_precio.Text), chk_disponible.Checked);
            MessageBox.Show("Articulo agregado: \n" + mimascota.ToString());

            milista.Add(mimascota);
        }
    }
}
