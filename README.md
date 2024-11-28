
# Gerenciador de Doações

## Propósito do Projeto

O **Gerenciador de Doações** é um sistema desenvolvido para facilitar a gestão de doações realizadas por e para ONGs. Ele permite:
- Cadastro de ONGs, doadores e beneficiários.
- Registro e acompanhamento de doações realizadas.
- Controle sobre o destino das doações.
- Geração de relatórios para as ONGs monitorarem suas atividades.

---

## Estrutura do Projeto

O projeto segue uma arquitetura em camadas, separando responsabilidades de forma clara:

- **GerenciadorDeDoacoes.Api**: Contém os controladores e endpoints da API. Implementa rotas e documentação Swagger.
- **GerenciadorDeDoacoes.Application**: Implementa a lógica de negócio do sistema. Contém serviços, DTOs e validações.
- **GerenciadorDeDoacoes.Domain**: Define as entidades e regras de negócio do sistema.
- **GerenciadorDeDoacoes.Infrastructure**: Responsável por lidar com o acesso a dados e integração com serviços externos.

---

## Como Usar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/) instalado.
- Banco de dados configurado (SQL Server, PostgreSQL ou outro conforme a configuração do projeto).
- IDE de sua preferência (Visual Studio, Visual Studio Code, etc).

### Configuração

1. Clone ou extraia o projeto no diretório de sua escolha:
   ```bash
   git clone https://github.com/seu-usuario/gerenciador-de-doacoes.git
   ```

2. Navegue até o diretório `GerenciadorDeDoacoes.Api`.
3. Configure a string de conexão do banco de dados no arquivo `appsettings.json`.
4. Restaure as dependências do projeto:
   ```bash
   dotnet restore
   ```
5. Execute as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```
6. Inicie o servidor da API:
   ```bash
   dotnet run
   ```
7. Acesse a documentação Swagger em:
   ```
   http://localhost:5000/swagger
   ```

### Testes

- Use ferramentas como Postman ou Insomnia para testar os endpoints.
- Scripts para testes automatizados podem ser encontrados na camada `Application` ou configurados nos projetos de teste.

---

## Estrutura de Diretórios

```plaintext
GerenciadorDeDoacoes/
├── GerenciadorDeDoacoes.Api
│   ├── Controllers/
│   ├── Program.cs
│   ├── Startup.cs
│   ├── appsettings.json
├── GerenciadorDeDoacoes.Application
│   ├── Services/
│   ├── DTOs/
│   ├── Validations/
├── GerenciadorDeDoacoes.Domain
│   ├── Entities/
│   ├── Interfaces/
├── GerenciadorDeDoacoes.Infrastructure
│   ├── Repositories/
│   ├── Database/
├── .vs
```

---

## Principais Funcionalidades

1. **Cadastro de ONGs**  
   Permite que ONGs se registrem com informações detalhadas sobre sua atuação.

2. **Registro de Doações**  
   Doadores externos podem realizar doações para ONGs.

3. **Gerenciamento de Beneficiários**  
   ONGs podem adicionar pessoas ou entidades que recebem as doações.

4. **Relatórios**  
   Relatórios detalhados sobre as atividades das ONGs e o uso das doações.

---

## Contato

- Desenvolvedor: Ronald Ronan Galeno Brito
- Email: ronaldronan14@gmail.com
