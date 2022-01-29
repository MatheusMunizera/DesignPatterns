using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    internal class SQLServerProduct : DbProduct
    {

        public string GetProductById(string id)
        {
            return $"SQLServer: O Id do produto é {id}";
        }
    }
}
