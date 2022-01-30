# Abstract Factory 

## O PROBLEMA - Cenário
A nossa aplicação está sendo um sucesso, mas agora temos uma nova demanda.

Criamos um marketplace de transportes, e não somente Uber, mas a 99 e outros parceiros podem estar conosco, agora além de termos
diferentes tipos de transportes, podemos ter diferentes tipos de empresas prestando o mesmo serviço, e nossa aplicação precisa
prever quais tipos de transportes estão disponíveis para cada empresa. Como são os mesmo tipos de serviços podemos utilizar o Abstract Factory

## A SOLUÇÃO
No Abstract Factory primeiro precisamos declarar explicitamente interfaces para cada produto distinto da família de produtos ( ex: veículos e aeronaves ).
Então podemos fazer todas as variantes dos produtos seguirem essas interfaces.

Em seguida declaramos a fábrica abstrata- uma interface com uma lsita de métodos de criação para todos os produtos que fazem parte da família de produtos
(Por exemplo, criarTransporteVeículo, criarTransporteAeronave). Esses métodos devem retornar tipos abstratos de produtos representados pelas interfaces que 
extraímos previamente. Veículo, Aeronave e assim por diante.
