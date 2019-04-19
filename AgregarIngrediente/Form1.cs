using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace AgregarIngrediente
{
    public partial class FormIngredientes : Form
    {
        public FormIngredientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioIngrediente negocio = new NegocioIngrediente();
            try
            {
                dgvIngredientes.DataSource = negocio.listarIngrediente();
                dgvIngredientes.Columns[0].Visible = false;
                dgvIngredientes.Columns[3].Visible = false;
                dgvIngredientes.Columns[4].Visible = false;
                dgvIngredientes.Columns[5].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AceptarAgregaIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = new Ingrediente();
            NegocioIngrediente negocio = new NegocioIngrediente();
            try
            {
                ingrediente.NombreIngrediente = textNombreIngrediente.Text;
                ingrediente.CantidadIngrediente = Convert.ToSingle(textCantidadIngrediente.Text);
                ingrediente.PrecioIngrediente = Convert.ToSingle(textPrecioIngrediente.Text);

                negocio.agregarIngrediente(ingrediente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
