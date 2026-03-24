# MerceariaFácil

## Sobre o Projeto

O MerceariaFácil é um sistema web desenvolvido para auxiliar pequenas mercearias no controle de produtos, estoque e vendas.
Este projeto foi criado com o objetivo de demonstrar conhecimentos fundamentais de desenvolvimento full stack para oportunidades de estágio ou júnior.

## Objetivo
Desenvolver um sistema simples que permita:

- Cadastro de produtos
- Controle de estoque
- Registro de vendas
- Atualização de estoque
- Visualização de vendas

## Funcionalidades
### Autenticação:
- Login de usuário
- Logout

### Gestão de Produtos:
- Cadastrar produto
- Editar produto
- Excluir produto
- Listar produtos

*Campos do produto:*
- Nome
- Preço
- Quantidade em estoque

### Vendas:
- Criar nova venda
- Adicionar produtos à venda
- Cálculo automático do total
- Atualização do estoque ao finalizar a venda

## Tecnologias utilizadas
### Banco de Dados:
- MySQL
### Backend:
- C#
### Frontend:
- Angular
- HTML
- CSS

## Modelagem do Banco de Dados
### Tabela: usuarios
- id
- nome
- email
- senha
### Tabela: produtos
- id
- nome
- preco
- quantidade
### Tabela: vendas
- id
- valor_total
- data
### Tabela: itens_venda
- id
- venda_id
- produto_id
- quantidade
- preco

**Relacionamentos:**
- Um usuário pode ter várias vendas
- Cada venda possui vários itens de venda
- Cada item de venda está relacionado a um produto

## Como executar o projeto
- Clonar repositório
- Instalar dependências
- Configurar banco de dados
- Iniciar backend
- Iniciar frontend
