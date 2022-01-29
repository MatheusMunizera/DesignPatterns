using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento Coletado");
        }

        public virtual void Validate() // Pensando que tanto Credito quanto debito podem efetuar 
        {
            throw new NotImplementedException();
        }
    }
}
