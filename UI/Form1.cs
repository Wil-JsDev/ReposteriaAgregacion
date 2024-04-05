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
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.DeepOrange400, TextShade.WHITE);
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


                ingrediente.Nombre = txtNombreI.Text;
                ingrediente.Cantidad = Convert.ToDouble(txtCantidad.Text);
                ingrediente.Precio = Convert.ToDouble(txtPrecio.Text);

                producto.AgregarIngredientes(ingrediente);
                this.datagrid.DataSource = null;
                this.datagrid.DataSource = producto.GetIngredietnes();
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

        private void txtNombreI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(datagrid)))
            {
                MessageBox.Show("No tienes ingredientes agregados");
            }
            else
            {
                producto.CalcularCosto();
                MessageBox.Show("Han sido enviados los datos");
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (producto.GetIngredietnes().Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este ingrediente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Ingredientes ingredienteEliminar = producto.GetIngredietnes()[0];
                    producto.GetIngredietnes().RemoveAt(0);
                    this.datagrid.DataSource = null;
                    this.datagrid.DataSource = producto.GetIngredietnes();
                    MessageBox.Show($"Se ha eliminado el ingrediente {ingredienteEliminar.Nombre}");
                }
            }
            else
            {
                MessageBox.Show("No hay ingredientes para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}



