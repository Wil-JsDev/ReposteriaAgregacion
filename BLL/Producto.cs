using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto : Ingredientes
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Caracteristicas { get; set;}
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
                costo += ingredientes.Precio;    
            }
            Precio = costo;
        }

        public bool QuitarIngredientes(Ingredientes ingredientes)
        {
           var contains = ListaIngredientes.Contains(ingredientes);

            if (contains)
            {
                ListaIngredientes.Remove (ingredientes);
                return true;
            } 
            
            return false;
        }


        #endregion
    }
}
