# API Universidade (Gerenciamento de Alunos, Cursos e Disciplinas)

## 📖 Sobre o projeto
A **API Universidade** é uma aplicação pública, desenvolvida durante as aulas de Programação para Internet, com o objetivo de gerenciar ações relacionadas a uma universidade fictícia. A API permite gerenciar **Alunos**, **Cursos**, **Disciplinas** e também conta com um sistema de autenticação via token JWT.

Com esta API, é possível realizar operações como adicionar, modificar, buscar e deletar registros, além de garantir a segurança através da autenticação de usuários.

---

## 🚀 Funcionalidades principais
- **Gerenciamento de Alunos:** CRUD completo para adicionar, editar, visualizar ou excluir alunos.
- **Gerenciamento de Cursos:** CRUD completo para os cursos, incluindo associações com disciplinas e alunos matriculados.
- **Gerenciamento de Disciplinas:** CRUD completo para manipular as disciplinas ofertadas por cursos.
- **Autorização JWT:** Geração de tokens para autenticação segura.

---

## 🛠️ Tecnologias utilizadas
- **C#**
- **.NET**
- **PostgreSQL**
- **Swagger** (documentação e testes da API)

---

## 📋 Pré-requisitos para rodar o projeto
1. **Instalar o .NET SDK**  
   - Baixe e instale o **.NET SDK** diretamente do site oficial: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
   - Após a instalação, abra um terminal e verifique se o .NET foi instalado corretamente com o comando:
  
     ```bash
     dotnet --version
     ```
     
     Este comando deve exibir a versão do SDK instalada.

2. **Instalar o Visual Studio Code**  
   - Baixe o VSCode em [https://code.visualstudio.com/](https://code.visualstudio.com/).
   - Instale as extensões necessárias:
     - **C# (by Microsoft)**.
     - **.NET Install Tool for Extension Authors** (opcional, mas recomendada).

3. **PostgreSQL**
   - Configure um banco de dados local ou remoto para conectar à API.

---

## 🚀 Como rodar o projeto
1. **Clone o repositório e entre no local do arquivo:**
     ```bash
     git clone https://github.com/seu-repositorio/api-universidade.git
     cd api-universidade
     ```

2. **Configure o banco de dados:**

   Abra o arquivo ```appsettings.json``` e insira a string de conexão do seu PostgreSQL:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=UniversidadeDB;Username=seu-usuario;Password=sua-senha"
     }
     ```
     
3. **Rode o projeto:**

   No terminal, execute:
   ```bash
   dotnet run
   ```

4. **Acesse o Swagger:**
   
   Após rodar o projeto, abra o navegador e acesse:
   http://localhost:5000/swagger

## ⚙️ Configuração do Token JWT
1. Entre no ```appsettings.json```
2. Na seção ```Jwt``` modifique o valor:
   ```json
   "Jwt": {
     "Key": "sua-chave-secreta",
   },
    ```
3. Na seção ```TokenConfiguration``` modifique os valores:
   ```json
   "TokenConfiguration": {
     "Audience": "seu-publico",
     "Issuer": "sua-api",
     "ExpireHours": "tempo-de-funcionamento-do-token",
   },
    ```
