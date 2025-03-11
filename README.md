# ToDoAPI + Web

.NET course work.
Add tasks with API which works with Postgres

## How to run

1. Clone the repository:
```
    git clone https://github.com/Warning233/todoapi.git
    cd todoapi
```
2. start local PostgreSQL server at 5432 as postgres with password `admin` (or simply change parameters in `appsettings.json`)

2. Restore dependencies:
```
    dotnet restore
```

3. Run both projects:
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

4. Open [local](http://localhost:5204) in your browser.