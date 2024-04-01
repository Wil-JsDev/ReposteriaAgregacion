using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Producto
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Caracteristicas { get; set; }
        public List<Ingredientes> ListaIngredientes = new List<Ingredientes>();
        #endregion

        #region Metodos 
        public void AgregarIngredientes(Ingredientes ingredientes)
        {
            ListaIngredientes.Add(ingredientes);
        }

        public void CalcularCosto()
        {
            double costo = 0;
            foreach (var ingredientes in ListaIngredientes)
            {
                costo += ingredientes.Precio * ingredientes.Cantidad;
            }
            MessageBox.Show($"El costo total del producto es {costo}");
            
        }

        public bool QuitarIngredientes(Ingredientes ingredientes)
        {
            var contains = ListaIngredientes.Contains(ingredientes);

            if (contains)
            {
                ListaIngredientes.Remove(ingredientes);
                return true;
            }

            return false;
        }

        public List<Ingredientes> GetIngredietnes()
        {
            return ListaIngredientes;
        }

        #endregion
    }
}
