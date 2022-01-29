using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    internal class MongoDBProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: O Id do produto é {id}";
        }
    }
}
