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
    public partial class FormJuguete : Form
    {
        BindingList<Juguete> milista;
        public FormJuguete()
        {
            milista= new BindingList<Juguete>();
            
            InitializeComponent();
            dataGridView1.DataSource = milista;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Juguete p = new Juguete(txt_nombre.Text, txt_marca.Text, decimal.Parse(mtxt_precio.Text), cbo_tipo.SelectedItem.ToString(), chk_disponible.Checked);
            MessageBox.Show("Articulo agregado: \n" + p.ToString());

            milista.Add(p);
        }

        private void FormJuguete_Load(object sender, EventArgs e)
        {
            cbo_tipo.SelectedIndex = 0;
        }
    }
}
