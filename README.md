# ToDoAPI + Web

.NET course work.
Add tasks with API which works with Postgres

## How to run

1. Clone the repository:
```
    git clone https://github.com/Warning233/todoapi.git
    cd todoapi
```
2. Start local PostgreSQL server at 5432 as postgres with password `admin` (or simply change parameters in `appsettings.json`)

3. Make database migrations:
```
    cd ToDoAPI
    dotnet ef migrations add InitialCreate
    dotnet ef database update
```
4. Restore dependencies:
```
    dotnet restore
```

5. Run both projects:
    - On Linux/macOS:
    ```
        chmod +x start.sh
        ./start.sh
    ```
    - On Windows (cmd):
    ```
        start.bat
    ```
    - On Windows (PowerShell):
    ```
        .\start.ps1
    ```

6. Open [local](http://localhost:5204) in your browser.
