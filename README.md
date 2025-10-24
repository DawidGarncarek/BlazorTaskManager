# Blazor Task Manager
### Aplikacja webowa do zarządzania zadaniami, stworzona w ASP.NET Blazor Server z autoryzacją i Microsoft SQL Server.

## Funkcje aplikacji
- Tworzenie, edytowanie i usuwanie zadań
- Organizowanie zadań w kategorie
- Oznaczanie zadań jako ukończone
- Uwierzytelnianie użytkowników (ASP.NET Identity)
- Obsługa terminów wykonania zadań
- Sortowanie i filtrowanie listy zadań
- Eksport do CSV
- Powiadomienia e-mail o zbliżających się terminach (opcjonalnie)

## Technologie
- Blazor Server (.NET 8.0)
- Entity Framework Core
- Microsoft SQL Server
- ASP.NET Identity (logowanie użytkowników)
- Bootstrap 5 (frontend)

## Wymagania systemowe
Zainstalowane oprogramowanie:
- .NET SDK 8.0
- Visual Studio 2022 (z zaznaczoną opcją "ASP.NET i programowanie w sieci Web")
- Microsoft SQL Server + SQL Server Management Studio (SSMS)

Dodatkowe pakiety do zainstalowania:
- W katalogu projektu uruchom w Terminalu lub PowerShell:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package CsvHelper
dotnet add package MailKit
```
- oraz instalacja EF Core Power Tools

## Instalacja i uruchomienie
🔹 Skopiuj projekt
W konsoli / terminalu wpisz:

  ```bash
  git clone https://github.com/TwojeRepo/BlazorTaskManager.git
  cd BlazorTaskManager
  (Podmień link na prawdziwy adres repozytorium, jeśli wrzucisz projekt na GitHub.)
  ```
🔹 Skonfiguruj bazę danych
Otwórz plik appsettings.json i ustaw połączenie do SQL Server:

  ```bash
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BlazorTaskManager;Trusted_Connection=True;TrustServerCertificate=True;"
  }
  ```
Utwórz bazę danych i wykonaj migracje:

  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```
🔹 Uruchom aplikację

  ```bash
  dotnet run
  ```

Aplikacja powinna być dostępna pod adresem:
https://localhost:5001

## Autorzy i kontakt
- Stworzone przez: Dawid
- E-mail: d_garncarek@wp.pl
