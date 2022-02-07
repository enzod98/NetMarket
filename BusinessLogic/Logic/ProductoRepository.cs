using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Entities;

namespace BusinessLogic.Logic
{
    public class ProductoRepository : IProductoRepository
    {
        public Task<Producto> GetProductoByIdAsync(int idProducto)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Producto>> GetProductosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
