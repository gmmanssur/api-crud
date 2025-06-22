# Api-Crud

Api-Crud is a structured full-stack CRUD application composed of a **.NET (C#) Web API** backend and an **Angular** frontend. It provides a clean, extensible foundation for user management, allowing the creation, reading, updating, and deletion of users from a database.

This project is designed with scalability, modularity, and clean code practices in mind. It currently supports core CRUD operations and will be continuously improved with additional features and best practices in software architecture.

---

## 🔧 Technologies

### Backend
- **.NET 8.0** (C#)
- **Entity Framework Core**
- **ASP.NET Core Web API**
- **SQL Server / PostgreSQL** *(choose based on configuration)*

### Frontend
- **Angular 16+**
- **TypeScript**
- **Bootstrap** (or other CSS framework of your choice)

---

## 📌 Features

### ✅ Implemented
- [x] Create new users
- [x] Retrieve users
- [x] Update users
- [x] Delete users
- [x] API structure using Controllers and Dependency Injection

### 🚧 In Progress / Planned

## Backend (.NET)
- 🔄 **FluentValidation** for request validation
- 🧱 **Custom Middleware** (e.g., error handling, logging)
- 🏗 **Scalable Architecture** (e.g., Service/Repository pattern)
- 🧠 **Design Patterns** (e.g., Unit of Work, Factory, Strategy)
- 🔐 **Security Enhancements**
  - JWT Authentication
  - Input sanitization and validation
  - Role-based access control
- 📄 API documentation with **Swagger**
- 🌐 Dockerization for easy deployment
- 🧪 Unit and Integration tests

- 
## Frontend (Angular)
- 📐 Component Architecture (clean, reusable UI components)
- 📡 Service Layer for HTTP requests to the API
- ✅ Reactive Forms with validation and feedback
- 🚥 Routing & Navigation Guards
- 🔒 JWT Authentication
- 🎨 UI/UX Improvements (e.g., modals, toast messages, loading spinners)
- 🌍 Environment Configuration for development and production
- 📦 State Management (optional, e.g., with RxJS or NgRx)

---

## 📁 Project Structure (Backend)

| Diretório / Arquivo | Descrição                                                              |
| ------------------- | ---------------------------------------------------------------------- |
| `Controllers/`      | Contém os endpoints da API que recebem as requisições HTTP             |
| `Business/`         | Implementa a lógica de negócio da aplicação                            |
| `Integration/`      | Implementa as chamadas externas à API.                                 |
| `Repositories/`     | Responsável pelo acesso e manipulação dos dados no banco               |
| `Program.cs`        | Ponto de entrada da aplicação ASP.NET Core                             |
| `appsettings.json`  | Arquivo de configuração da aplicação (ex: connection strings, logging) |

---

## 🧪 Running the Project

### FrontEnd (Angular)
cd frontend-folder

npm install

ng serve

### Backend (.NET)
cd ApiCrud

dotnet restore

dotnet build

dotnet run

---

## 🧑‍💻 Contributing
Feel free to fork, improve, or suggest changes. All contributions are welcome! Please ensure your code follows the existing architecture and coding conventions.

##✨ Contact
Developed by Gustavo Manssur
Feel free to reach out via LinkedIn [https://www.linkedin.com/in/gustavo-manssur-1a4b5a1a0/] or Email [contato.gmanssur@gmail.com].
