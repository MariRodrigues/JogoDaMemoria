# JogoDaMemoria - Três Espiãs Demais
Jogo da memória feito em C# - Três Espiãs Demais

![image](https://github.com/MariRodrigues/JogoDaMemoria/assets/46384658/273cc2ab-137e-4b50-8008-c6bea1a64a19)

Para executar, siga as instruções:

- Na classe Forms2.cs há a configuração com o banco de dado. Na String de conexão substitua o "uid" (userId) e o "pwd" (password) com as suas credenciais. 
- No banco de dados, deverá ser criado o banco ``` jogomemoria ``` (ou outro nome caso queira editar) com uma tabela ``` usuario ```, conforme abaixo:

```
create database jogomemoria;

use jogomemoria;

create table usuario (
nome varchar(30),
nick varchar(30)
)
```
