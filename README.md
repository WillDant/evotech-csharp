# Documentação do Projeto: Sistema de Gerenciamento de Clientes e Procedimentos

## Descrição do Projeto

Este projeto consiste em um sistema de gerenciamento de clientes, endereços, procedimentos e redes credenciadas. O sistema permite realizar operações de cadastro, edição, exclusão e consulta de dados através de uma API RESTful.

## Estrutura do Projeto

A estrutura do projeto é organizada em camadas, seguindo os princípios de Clean Architecture:

- **Domain**: Contém as entidades e interfaces do domínio.
- **Application**: Contém os DTOs (Data Transfer Objects) e interfaces dos serviços de aplicação.
- **Infrastructure**: Implementação do contexto do banco de dados e repositórios.
- **Presentation**: Controladores da API que expõem os serviços ao cliente.

## Entidades

### ClienteEntity

Representa um cliente no sistema.

- `id_clie`: Identificador único do cliente (int).
- `nm_clie`: Nome do cliente (string).
- `dt_nasc`: Data de nascimento do cliente (DateTime).
- `genero`: Gênero do cliente (string).
- `endereco`: Endereço do cliente (string).
- `telefone`: Telefone do cliente (string).
- `email`: Email do cliente (string).
- `dt_cadastro`: Data de cadastro do cliente (DateTime).
- `senha`: Senha do cliente (string).

### EnderecoEntity

Representa um endereço no sistema.

- `id_end`: Identificador único do endereço (string).
- `cep`: Código postal do endereço (string).
- `logradouro`: Logradouro do endereço (string).
- `num_end`: Número do endereço (string).
- `compl_end`: Complemento do endereço (string).
- `bairro`: Bairro do endereço (string).
- `cidade`: Cidade do endereço (string).
- `uf`: Unidade federativa do endereço (string).

### ProcedimentoEntity

Representa um procedimento no sistema.

- `id_proc`: Identificador único do procedimento (int).
- `nome_proc`: Nome do procedimento (string).
- `descricao`: Descrição do procedimento (string).
- `preco`: Preço do procedimento (decimal).

### RedeCredenciadaEntity

Representa uma rede credenciada no sistema.

- `id_empresa`: Identificador único da empresa (string).
- `cnpj`: CNPJ da empresa (string).
- `dt_cadastro`: Data de cadastro da empresa (string).
- `nm_empresa`: Nome da empresa (string).
- `especialidade`: Especialidade da empresa (string).
- `telefone`: Telefone da empresa (string).
- `email`: Email da empresa (string).

## Funcionalidades da API

A API oferece as seguintes funcionalidades:

### Cliente

- `GET /api/cliente`: Obtém todos os clientes.
- `GET /api/cliente/{id_clie}`: Obtém um cliente específico por ID.
- `POST /api/cliente`: Cadastra um novo cliente.
- `PUT /api/cliente/{id_clie}`: Atualiza um cliente existente.
- `DELETE /api/cliente/{id_clie}`: Remove um cliente existente.

### Endereco

- `GET /api/endereco`: Obtém todos os endereços.
- `GET /api/endereco/{id_end}`: Obtém um endereço específico por ID.
- `POST /api/endereco`: Cadastra um novo endereço.
- `PUT /api/endereco/{id_end}`: Atualiza um endereço existente.
- `DELETE /api/endereco/{id_end}`: Remove um endereço existente.

### Procedimento

- `GET /api/procedimento`: Obtém todos os procedimentos.
- `GET /api/procedimento/{id_proc}`: Obtém um procedimento específico por ID.
- `POST /api/procedimento`: Cadastra um novo procedimento.
- `PUT /api/procedimento/{id_proc}`: Atualiza um procedimento existente.
- `DELETE /api/procedimento/{id_proc}`: Remove um procedimento existente.

### Rede Credenciada

- `GET /api/redecredenciada`: Obtém todas as redes credenciadas.
- `GET /api/redecredenciada/{id_empresa}`: Obtém uma rede credenciada específica por ID.
- `POST /api/redecredenciada`: Cadastra uma nova rede credenciada.
- `PUT /api/redecredenciada/{id_empresa}`: Atualiza uma rede credenciada existente.
- `DELETE /api/redecredenciada/{id_empresa}`: Remove uma rede credenciada existente.

## Tecnologias Utilizadas

- **.NET Core**: Framework para desenvolvimento da API.
- **Entity Framework Core**: ORM para acesso ao banco de dados.
- **Swagger**: Documentação e testes da API.
- **SQLite ou SQL Server**: Banco de dados utilizado (especificar conforme sua escolha).

## Como Executar o Projeto

1. Clone o repositório.
2. Abra o projeto no Visual Studio ou VS Code.
3. Execute o comando `dotnet restore` para restaurar as dependências.
4. Execute o comando `dotnet run` para iniciar a API.
5. Acesse a documentação da API em `http://localhost:5000/swagger` (ou a porta configurada).

## Considerações Finais

Esta documentação fornece uma visão geral do projeto e suas funcionalidades. Para mais detalhes, consulte o código-fonte e a estrutura das classes.
