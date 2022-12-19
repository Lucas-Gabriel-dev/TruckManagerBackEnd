# TruckManagerBackEnd
![version]( https://img.shields.io/badge/version-1.0.0-Green)
Projeto desenvolvido para aprimorar conhecimentos

## Sobre
TruckManager é um crud que tem como finalidade fazer o gerenciamento de caminões, com possibilidades de visualizar, editar, excluir ou adicionar caminhões
no sistema.
<br>
<br>

# Ferramentas Utilizadas
Logo abaixo, irei descrever quais foram as ferramentas utilizadas para o desenvolvimento do BackEnd.<br>

## .NET 6
Para todo o desenvolivmento foi o utilizado o .NET 6, que oferece diversos recursos e pacotes para o desenvolvimento. Os pacotes utilizados no desenvolvimento
foram: <br> 

<b> Microsoft.AspNet.WebApi.Cors: </b> Foi o principal recurso utilizado no desenvolvimento, uma vez que o BackEnd se comunica com o Front em API's. <br>

<b> Microsoft.EntityFrameworkCore.Design: </b> Foi o ORM utilizado para realizar consultar, atualizar, apagar e enviar dados para o banco de dados. <br>  

<b> Npgsql.EntityFrameworkCore.PostgreSQL: </b> Pacote que foi utilizado para o EntityFramework poder se comunicar com o banco de dados PostgreSQL.
<br>
<br>

## C#
Linguagem de programação que foi utilizada para o desenvimento. O C# oferece diversos recursos que facilitam na hora do desenvolimento.
<br>
<br>

## PostgreSQL
Banco de dados que foi utilizado para armazenar os dados da aplicação.
<br>
<br>

# Rotas da aplicação
A aplicação oferece diversas rotas, onde na maioria é necessário estar autenticado para utilizar.<br>

## GET
### Get All Trucks - https://localhost:7042/Truck/AllTrucks<br>
Rota utilizada para listar todos os caminhões disponíveis no site.<br>

### Find Truck - https://localhost:7042/Truck/{id}
Rota utilizada para buscar detalhes de algum caminhão específico.<br>

## POST
### Add Truck - https://localhost:7042/Truck/AddTruck
Rota utilizada para adicionar novos caminhões à base de dados. (Obs: Só é possível adicionar modelos FH e FM)<br>
JSON: <br>
{<br>
	"model": "FH",<br>
  "yearManufacture": 2022,<br>
  "modelYear": 2023<br>
}<br>

## PATCH
### Update Truck - https://localhost:7042/Truck/UpdateTruck<br>
Rota utilizada para atualizar caminhões armazenados na base de dados.<br>
JSON: <br>
{<br>
  "id": "11",<br>
	"model": "FH",<br>
  "yearManufacture": 2022,<br>
  "modelYear": 2023<br>
}<br>


## DELETE
### Delete Truck - https://localhost:7042/Truck/DeleteTruck/{id}<br>
Rota utilizada para deletar caminhões da base de dados.<br>

<br>
<h4 align="center">
✅  TruckManager 🚀 Concluído!!!  ✅
</h4>


