# ProductManager

## Product Manager
O Product Manager é um aplicativo web simples, em ASP.NET WebForms, para gerenciar produtos. Ele permite adicionar, editar, listar e excluir produtos em um banco de dados.

## Funcionalidades
- Adicionar um novo produto com nome e preço.
- Editar os detalhes de um produto existente.
- Listar todos os produtos em uma tabela.
- Deletar produtos.

## Pré-requisitos
Antes de começar, verifique se você tem o seguinte instalado:
- Visual Studio 2022 (ou outra IDE de sua escolha)
- SQL Server 2017 (ou equivalente)
- SQL Server Management Studio 20.2 (ou equivalente)

## Instalação
1. Clone este repositório para a sua máquina local.
2. Abra o projeto no Visual Studio.
3. Configure a string de conexão no arquivo Web.config para apontar para o seu banco de dados SQL Server.
4. Execute o aplicativo.
5. A tabela Products deve ter sido criada pelo Database First, porém caso deseje criá-la manualmente, execute o seguinte script:
```
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100),
    Price DECIMAL(10, 2)
);
```

## Configuração do Banco de Dados
- O aplicativo utiliza o Entity Framework (EF) para se comunicar com o banco de dados.
- A classe DbContext representa o contexto do banco de dados e mapeia a tabela “Products” para a classe Product.

## Uso
1. Acesse a página inicial para listar todos os produtos.
2. Clique em “Adicionar Produto” para inserir um novo produto.
3. Clique em “Editar/Deletar” para modificar ou excluir um produto existente.
