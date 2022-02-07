using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Producto
    {
        public int IdProducto { get; set; } // Cuando nuestra propiedad comienza con mayúscula (PascalCase), EF entiende que se trata de una llave primaria/foránea en la BD
                                            // si el nombre de la variable contiene 'Id' se asume que es la llave primaria de la tabla
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int Marca { get; set; }
        [Column(TypeName="decimal(18,4)")]
        public decimal Precio { get; set; }
        public string Imagen { get; set; }

    }
}
