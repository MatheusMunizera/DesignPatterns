using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* SRP - Single Responsability Principle
             * 
             * A ideia é que cada classe deve ter uma ÚNICA responsabilidade
             * No exemplo, criei duas classes dentro da pasta Utils: Client e Notify, client é uma classa basica de um CRUD, com create delete e update
             * e na classe Notify, é uma classe de notificação ao usuario.
             * 
             * As duas seguem SRP, a classe Client somente tem a responsabilidade do crud e o notify somente a de notificar o cliente.
             * A junção das duas em uma, seria uma quebra do princípio.
             * 
             * Fazendo isso temos uma maior manutenibilidade
             * 
             */



        }


        

    }
}
