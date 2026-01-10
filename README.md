# 📈 SmartStockPulse

> *An intelligent, high-performance backend for stock market management*

![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)
![C#](https://img.shields.io/badge/C%23-13.0-239120.svg)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-blueviolet.svg)
![REST API](https://img.shields.io/badge/API-REST-green.svg)
![Architecture](https://img.shields.io/badge/Architecture-Clean-lightgrey.svg)

---

## 🌟 Overview

**SmartStockPulse** is a modern, scalable **Stock Management REST API** built using **.NET 9** and **C# 13**.
It follows **Clean Architecture** and **Domain-Driven Design** principles to ensure maintainability, testability, and high performance.

This project provides a solid backend foundation for applications that require **stock tracking, price management, and market data handling**.

---

## ✨ Key Features

* 🚀 **High Performance** – Powered by .NET 9 and async programming
* 🧼 **Clean Architecture** – Clear separation of concerns
* 📦 **RESTful API** – Well-structured CRUD endpoints
* 🧩 **Scalable Design** – Ready for database & cloud integration
* 🌍 **Cross-Platform** – Runs on Windows, Linux, and macOS

---

## 🏛️ Project Architecture

```
SmartStockPulse/
├── 🎯 SmartStockPulse.API
│   ├── Controllers/        # API endpoints
│   ├── Program.cs         # Application entry point
│   └── appsettings.json   # Configuration
│
├── 📋 SmartStockPulse.Application
│   ├── Interfaces/        # Service contracts
│   └── Services/          # Business logic
│
├── 🏗️ SmartStockPulse.Domain
│   └── Entities/          # Core domain models
│
└── 💾 SmartStockPulse.Infrastructure
    └── Repositories/      # Data access layer
```

---

## 🎭 Design Patterns & Principles

* **Clean Architecture**
* **Repository Pattern**
* **Service Layer Pattern**
* **Dependency Injection**
* **SOLID Principles**

---

## 🚀 Getting Started

### 🔧 Prerequisites

* .NET 9 SDK
* Visual Studio / VS Code / JetBrains Rider

---

### 📥 Installation

1. **Clone the repository**

```bash
git clone https://github.com/Sachithmadushanka/SmartStockPulse-Backend
cd SmartStockPulse
```

2. **Restore dependencies**

```bash
dotnet restore
```

3. **Build the project**

```bash
dotnet build
```

4. **Run the API**

```bash
dotnet run --project SmartStockPulse.API
```

5. **Open Swagger UI**

```
https://localhost:5146/swagger
```

---

## 📡 API Endpoints

| Method   | Endpoint          | Description        |
| -------- | ----------------- | ------------------ |
| 📋 GET   | `/api/stock`      | Get all stocks     |
| 🔍 GET   | `/api/stock/{id}` | Get stock by ID    |
| ➕ POST   | `/api/stock`      | Create a new stock |
| ✏️ PUT   | `/api/stock/{id}` | Update stock       |
| ❌ DELETE | `/api/stock/{id}` | Delete stock       |

---

## 🧪 Sample Requests

### ➕ Create Stock

```http
POST /api/stock
Content-Type: application/json

{
  "symbol": "AAPL",
  "companyName": "Apple Inc.",
  "currentPrice": 189.45
}
```

### 📤 Sample Response

```json
{
  "id": 1,
  "symbol": "AAPL",
  "companyName": "Apple Inc.",
  "currentPrice": 189.45,
  "lastUpdated": "2026-01-10T08:30:00Z"
}
```

---

## 💡 Core Domain Model

### 📊 Stock Entity

* **Id** – Unique identifier
* **Symbol** – Stock ticker (e.g., AAPL, MSFT)
* **CompanyName** – Full company name
* **CurrentPrice** – Latest price
* **LastUpdated** – Timestamp of update

---

## 🛠️ Development & Build

### 🧪 Run Tests

```bash
dotnet test
```

### 📦 Publish for Production

```bash
dotnet publish -c Release -o ./publish
```

---

## 🗺️ Roadmap

* [ ] 🔐 JWT Authentication & Authorization
* [ ] 💾 Database Integration (EF Core + SQL Server)
* [ ] 📡 Real-Time Updates with SignalR
* [ ] 🔍 Search & Filtering
* [ ] ☁️ Cloud Deployment (Azure)


---


## 🙏 Acknowledgments

* 💙 Microsoft .NET Team
* 🌟 ASP.NET Core Community
* 🧠 Clean Architecture Concepts by Uncle Bob

---

<div align="center">

**Built using .NET 9 & C# 13**

</div>