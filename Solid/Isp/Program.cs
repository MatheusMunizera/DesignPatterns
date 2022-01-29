using Isp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  ISP - Interface Segregation Principle
             *  
             *  Tendo em vista que interface é um contrato, aqueles que assinam o contrato não devem ser obrigados a implementar métodos que eles não utilizam.
             *  Seguindo isso, Interfaces devem ser mais diretas, resumidas que declaram seus membros que realmente são necessários.
             *  Nisso temos interfaces mais enxutas e objetivas
             *  
             *  Esse principio auxilia também nos demais princripios, minimizando a dependencia, aplicando uma melhor singularidade
             * 
             *  No exemplo abaixo, há 3 Interfaces separadas e bem objetivas, Há um IVehicle que nos dá o starEngine, em que ambos como moto e carro utilizam.
             *  Há também ICar e IMotorcycle, cada um deles implementando seu meio de configuração de carro e moto.
             *  
             *  Com essa separação em 3 interfaces, ao vermos como na classe Motorcycle.cs não há relação alguma com ICar, não tendo que implementar algo desnecessário.
             */





            Car car = new Car("Azul", 2022, 4.0, 2, 2);
            Motorcycle moto = new Motorcycle("Azul", 2022, 600);

            Console.ReadLine();
        }
    }
}
