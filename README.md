<div align="center">
 
# API Levva Coins

<img src="http://img.shields.io/static/v1?label=STATUS&message=FINALIZADO&color=green&style=for-the-badge"/> <img src="http://img.shields.io/static/v1?label=release%20date&message=202023&color=green&style=for-the-badge"/> <img src="http://img.shields.io/static/v1?label=license&message=MIT&color=informational&style=for-the-badge"/>
</div>

Este projeto consiste em uma API construída para lidar com uma aplicação financeira, oferecendo recursos para o controle do usuário em relação às suas transações, entradas e saídas.
</div>

## Contratos

<details>
<summary>Login</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/auth`

**Método**: `POST`

**Requisição**:

```json
{
  "email": "email@example.com",
  "password": "123456"
}
```

**Resposta 200**:

```json
{
  "id": "uuid-v4",
  "email": "email@example.com",
  "token": "bearer.token",
  "avatar": "https://images.com/image1"
}
```

**Resposta 401**:

```json
{
  "hasError": true,
  "message": "Usuário ou senha inválidos."
}
```
</details>

<details>
<summary>Criar Usuário</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/user`

**Método**: `POST`

**Requisição**:

```json
{
  "name": "John Doe",
  "email": "email@example.com",
  "password": "123456",
  "avatar": "https://images.com/image1"
}
```

**Resposta 201**:

N/A

**Resposta 400**:

```json
{
  "hasError": true,
  "message": "Esse e-mail já existe."
}
```
</details>

<details>
<summary>Obter um Usuário</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/user/:userId`

**Método**: `GET`

**Requisição**:

```plaintext
URL Params:
userId (uuid-v4)

Headers:
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 200**:

```json
{
  "id": "uuid-v4",
  "name": "John Doe",
  "email": "email@example.com",
  "avatar": "https://images.com/image1"
}
```

**Resposta 400**:

```json
{
  "hasError": true,
  "message": "Esse usuário não existe."
}
```
</details>

<details>
<summary>Atualizar um Usuário</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/user/:userId`

**Método**: `PUT`

**Requisição**:

```plaintext
URL Params:
userId (uuid-v4)

Body:

{
  "avatar": "https://images.com/image1",
  "name": "John Doe"
}

Headers:
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 204**:

N/A

**Resposta 400**:

```json
{
  "hasError": true,
  "message": "Esse usuário não existe."
}
```
</details>

<details>
<summary>Criar Categoria</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/category`

**Método**: `POST`

**Requisição**:

```json
{
  "description": "Alimentação"
}

Headers:
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 201**:

N/A

**Resposta 400**:

```json
{
  "hasError": true,
  "message": "Uma categoria com esse nome já existe."
}
```
</details>

<details>
<summary>Obter todas as Categorias</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/category`

**Método**: `GET`

**Requisição**:

```plaintext
Headers:
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 200**:

```json
[
  {
    "id": "uuid-v4",
    "description": "Café"
  },
  {
    "id": "uuid-v4",
    "description": "Alimentação"
  },
  {
    "id": "uuid-v4",
    "description": "Casa"
  }
]
```
</details>

<details>
<summary>Criar Transação</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/transaction`

**Método**: `POST`

**Requisição**:

```json
{
  "description": "Pizza com amigos",
  "amount": 100,
  "type": "Depósito", // ou "Crédito"
  "categoryId": "uuid-v4"
}

Headers:
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 201**:

N/A
</details>

<details>
<summary>Obter todas as Transações</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/transaction`

**Método**: `GET`

**Requisição**:

```plaintext
Headers:
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 200**:

```json
[
  {
    "id": "uuid-v4",
    "description": "Café com amigos",
    "amount": 50,
    "type": "Depósito",
    "categoryId": "uuid-v4"
  },
  {
    "id": "uuid-v4",
    "description": "Pizza com amigos",
    "amount": 100,
    "type": "Depósito",
    "categoryId": "uuid-v4"
  },
  {
    "id": "uuid-v4",
    "description": "Salário março 2023",
    "amount": 1200,
    "type": "Crédito",
    "categoryId": "uuid-v4"
  }
]
```
</details>

<details>
<summary>Remover Transação</summary>

**Host**: `http://localhost:3333/api`

**Endpoint**: `/transaction/:transactionId`

**Método**: `DELETE`

**Requisição**:

URL Params:
- `transactionId` (uuid-v4)

Headers:

```plaintext
{
  "authorization": "Bearer bearer.token"
}
```

**Resposta 204**:

N/A

**Resposta 400**:

```json
{
  "hasError": true,
  "message": "Essa transação não existe."
}
```
</details>

## Tecnologias Utilizadas

- C# .NET
- ASP.NET Core
- Entity Framework Core
- Swagger
- SQlite
- JSON Web Token (JWT)

## Como Rodar o Projeto Localmente

1. Clone o repositório:

```plaintext
git clone https://github.com/heitorgandolfi/Levva-Coins-Api.git
```

2. Abra o projeto em sua IDE preferida (por exemplo, Visual Studio ou Visual Studio Code).

3. Configure o banco de dados:

Verifique se você tem o SQL Server instalado.
No arquivo appsettings.json, verifique e atualize a string de conexão com o banco de dados.

4. Execute as migrações do banco de dados:

Abra o Terminal (no Visual Studio Code) ou o Console do Gerenciador de Pacotes (no Visual Studio).

Execute o seguinte comando:

```plaintext
dotnet ef database update
```

5. Inicie o servidor:

No Visual Studio Code, execute o seguinte comando no Terminal:

```plaintext
dotnet run
```

No Visual Studio, basta pressionar o botão "Executar" ou "Iniciar" (F5).

## Licença

[MIT License](LICENSE)
