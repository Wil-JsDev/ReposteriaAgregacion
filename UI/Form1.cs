using BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmPrincipal : MaterialForm
    {
        Producto producto = new Producto();
        public FrmPrincipal()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange400, TextShade.WHITE);
        }

        private void btnEnviarI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreI.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {

                MessageBox.Show("Varon va a dejar los campos en blanco");

            }
            else
            {
                Ingredientes ingrediente = new Ingredientes();

                bool validacion = Convert.ToBoolean(ingrediente.Nombre = txtNombreI.Text);
                
                ingrediente.Cantidad = Convert.ToDouble(txtCantidad.Text);
                ingrediente.Precio = Convert.ToDouble(txtPrecio.Text);

                producto.AgregarIngredientes(ingrediente);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = producto.GetIngredietnes();
                MessageBox.Show($"Se ha agregado el ingrediente {ingrediente.Nombre}");
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtNombreI.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }
    }
}
