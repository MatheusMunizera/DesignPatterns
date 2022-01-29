using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    internal class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pontuação Creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Rewards Valido");
        }
    }
}
