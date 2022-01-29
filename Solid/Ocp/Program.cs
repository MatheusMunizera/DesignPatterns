using Ocp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * OCP - Open/Closed Principle
             * 
             * A ideia de que o código deve ser aberto para exetensões mas fechado para alterações.
             * Geralmente utilizado com herança e interface, quando se altera classes, modulo ou função com certeza irá afetar suas classes depententes.
             * Tendo isso em vista, deve se manter fechado, ou seja, sem alterações no código ja existente, evitando possivel falha nas dependencias que já estão utilizando o recurso.
             * 
             * Porém, vamos pensar em um caso que eu REALMENTE preciso alterar essa classe que deveria estar fechada, o correto seria implementar em uma nova versão
             * Por exemplo, o mercado pago em sua API 2.0 tem todos suas classes seguindo o principio SOLID, porém com a chegada do PIX é inevitavel uma modificação na API.
             * Altera-la diretamente pode gerar muitos problemas para suas dependencias, então a melhor maneira de modificar a api é lançar uma nova versão, que da suporte
             * ao PIX, e nesta versão ele já está moldado e preparado para ter suas classes trabalhando juntas de modo que nao afete ou altere as classes da versão anterior.
             * 
             * Fazendo isso temos um custo menor de tempo, evitando ter que alterar a principal e depois todas suas dependencias.
             * 
             */



            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if(type == TypeVehicle.CAR)
            {
                Car car = new Car("Preto", 2020, 2.0, 5, 4);

            }
            else
            {
                Motorcycle moto = new Motorcycle("Amarela", 2020, 1.0);
            }

            Console.ReadLine();





        }
    }
}
