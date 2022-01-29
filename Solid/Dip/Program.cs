using Dip.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    internal class Program
    {

        /*
         * DIP - Dependency Inversion Principle
         * 
         * - Um modulo de alto nivel nao pode depender de um modulo de baixo nivel, ambos devem depender apenas de abstrações
         * 
         * No exemplo, em App.Config há minha configuração do meu Banco de dados.
         * Minha Factory, DbProductFactory, averigua essa configuração e de acordo com ela irá prosseguir com o modelo respectivo.
         * 
         * Então, como minha configuração diz ser um SQLServer, DbFactory fará uso do Model SQLServer.
         * Lembrando que há dois modelos, sendo, SQLServer e MongoDB.
         * 
         * Nisso, quando utilizo o Payment, ele utiliza o metodo Create vindo da Factory e Payment não precisa
         * saber qual o modelo que estou utilizano, ele deve executar esse metodo independente do modelo.
         * 
         * Com DIP, consigo alterar a configuração do tipo de banco de dados, como de SQLServer para MongoDB, sem que 
         * payment pare de funcionar, pois ele depende apenas de uma abstração.
         * 
         * Essa abstração é responsavel por identificar qual o modelo
         * e dentro de cada modelo, será feito o mesmo método, como o Create porém utilizando as caracteristicas do modelo, 
         * por exemplo, um método Create no SQLServer será feito de forma diferente do que no MongoDB.
         * 
         * Porém mesmo com essa diferença eu ainda consigo trocar o banco de dados e executar Payment
         * 
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
            PaymentProcess pay = new PaymentProcess();
            pay.Pay("Cringe");
            Console.ReadLine();
        }
    }
}
