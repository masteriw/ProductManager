# ProductManager

## Product Manager
O Product Manager é um aplicativo web simples para gerenciar produtos. Ele permite adicionar, editar, listar e excluir produtos em um banco de dados.

## Funcionalidades
- Adicionar um novo produto com nome e preço.
- Editar os detalhes de um produto existente.
- Listar todos os produtos em uma tabela.
- Deletar produtos.
- 
## Pré-requisitos
Antes de começar, verifique se você tem o seguinte instalado:
- Visual Studio (ou outra IDE de sua escolha)
- SQL Server (ou outro banco de dados compatível)

## Instalação
1. Clone este repositório para a sua máquina local.
2. Abra o projeto no Visual Studio.
3. Configure a string de conexão no arquivo Web.config para apontar para o seu banco de dados SQL Server.
4. Execute o aplicativo.

## Configuração do Banco de Dados
- O aplicativo utiliza o Entity Framework (EF) para se comunicar com o banco de dados.
- A classe ProductContext representa o contexto do banco de dados e mapeia a tabela “Products” para a classe Product.

## Uso
1. Acesse a página inicial para listar todos os produtos.
2. Clique em “Adicionar Produto” para inserir um novo produto.
3. Clique em “Editar/Deletar” para modificar ou excluir um produto existente.
