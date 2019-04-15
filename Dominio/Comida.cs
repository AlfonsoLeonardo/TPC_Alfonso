using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comida
    {
        public int IdComida { get; set; }
        public string NombreComida { get; set; }
        public List<Ingrediente> Ingrediente { get; set; }
        public List<float> CantidadPorIngrediente { get; set; }
    }
}
