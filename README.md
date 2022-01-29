
# <a href="#SRP">S</a> <a href="#OCP">O</a> <a href="#LSP">L</a> <a href="#ISP">I</a> <a href="#DIP">D</a> 


## SRP

Single Responsability Principle

- A ideia é que cada classe deve ter uma ÚNICA responsabilidade


No exemplo, criei duas classes dentro da pasta Utils: Client e Notify, client é uma classa basica de um CRUD, com create delete e update e na classe Notify, é uma classe de notificação ao usuario.

As duas seguem SRP, a classe Client somente tem a responsabilidade do crud e o notify somente a de notificar o cliente.

A junção das duas em uma, seria uma quebra do princípio.

Fazendo isso temos uma maior manutenibilidade


## OCP
Open/Closed Principle

- A ideia de que o código deve ser aberto para exetensões mas fechado para alterações.


Geralmente utilizado com herança e interface, quando se altera classes, modulo ou função com certeza irá afetar suas classes depententes.

Tendo isso em vista, deve se manter fechado, ou seja, sem alterações no código ja existente, evitando possivel falha nas dependencias que já estão utilizando o recurso.

Porém, vamos pensar em um caso que eu REALMENTE preciso alterar essa classe que deveria estar fechada, o correto seria implementar em uma nova versão
Por exemplo, o mercado pago em sua API 2.0 tem todos suas classes seguindo o principio SOLID, porém com a chegada do PIX é inevitavel uma modificação na API.
Altera-la diretamente pode gerar muitos problemas para suas dependencias, então a melhor maneira de modificar a api é lançar uma nova versão, que da suporte
ao PIX, e nesta versão ele já está moldado e preparado para ter suas classes trabalhando juntas de modo que nao afete ou altere as classes da versão anterior. 

Fazendo isso temos um custo menor de tempo, evitando ter que alterar a principal e depois todas suas dependencias.


## LSP
Liskov Substituiton Principle

- Os objetos da superclasse deve ser substituiveis pelos objetos da subclasse sem quebrar o código.
Então os membros da subclasse devem se comportar como a superclasse

No exemplo, Há 2 subclasses CreditCard, DebitCard que derivam de NubankCard, caso eu tenha um código
como mostrado abaixo aonde eu utilizos os membros da subclasse, quando eu troco por qualquer uma outra subclasse, a implementação
deve continuar funcionando.
E se eu adicionar uma nova subclasse respeitando a superclasse,ao substituir por NubankRewards deve-se continuar funcionando.


## ISP
Interface Segregation Principle

- Tendo em vista que interface é um contrato, aqueles que assinam o contrato não devem ser obrigados a implementar métodos que eles não utilizam.

Seguindo isso, Interfaces devem ser mais diretas, resumidas que declaram seus membros que realmente são necessários.

Nisso temos interfaces mais enxutas e objetivas. 
Esse principio auxilia também nos demais princripios, minimizando a dependencia, aplicando uma melhor singularidade

No exemplo há 3 Interfaces separadas e bem objetivas, Há um IVehicle que nos dá o starEngine, em que ambos como moto e carro utilizam.
Há também ICar e IMotorcycle, cada um deles implementando seu meio de configuração de carro e moto. 
Com essa separação em 3 interfaces, ao vermos como na classe Motorcycle.cs não há relação alguma com ICar, não tendo que implementar algo desnecessário.

## DIP
Dependency Inversion Principle

- Um modulo de alto nivel nao pode depender de um modulo de baixo nivel, ambos devem depender apenas de abstrações

No exemplo, em App.Config há minha configuração do meu Banco de dados.
Minha Factory, DbProductFactory, averigua essa configuração e de acordo com ela irá prosseguir com o modelo respectivo.
Então, como minha configuração diz ser um SQLServer, DbFactory fará uso do Model SQLServer.
 Lembrando que há dois modelos, sendo, SQLServer e MongoDB.

Nisso, quando utilizo o Payment, ele utiliza o metodo Create vindo da Factory e Payment não precisa
saber qual o modelo que estou utilizano, ele deve executar esse metodo independente do modelo.

Com DIP, consigo alterar a configuração do tipo de banco de dados, como de SQLServer para MongoDB, sem que 
payment pare de funcionar, pois ele depende apenas de uma abstração.
Essa abstração é responsavel por identificar qual o modelo e dentro de cada modelo, será feito o mesmo método, como o Create porém utilizando as caracteristicas do modelo, 
por exemplo, um método Create no SQLServer será feito de forma diferente do que no MongoDB.
Porém mesmo com essa diferença eu ainda consigo trocar o banco de dados e executar Payment
