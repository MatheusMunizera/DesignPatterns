using Lsp.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* LSP - Liskov Substituiton Principle
             * 
             *  Pelo o que entendi, os objetos da superclasse deve ser substituiveis pelos objetos da subclasse sem quebrar o código.
             *  Então os membros da subclasse devem se comportar como a superclasse
             *  
             *  No exemplo, Há 2 subclasses CreditCard, DebitCard que derivam de NubankCard, caso eu tenha um código
             *  como mostrado abaixo aonde eu utilizos os membros da subclasse, quando eu troco por qualquer uma outra subclasse, a implementação
             *  deve continuar funcionando.
             *  E se eu adicionar uma nova subclasse respeitando a superclasse,ao substituir por NubankRewards deve-se continuar funcionando.
             * 
             * 
             * 
             * 
             */




            /* 
             * Se eu trocar a instancia de card por qualquer uma dessas 3 abaixo, o código deve continuar funcionando.
             */

            // DebitCard card = new DebitCard();
            //CreditCard card = new CreditCard();
            NubankRewards card = new NubankRewards();


            card.Validate();
            card.CollectPayment();

            Console.ReadLine();



        }
    }
}
