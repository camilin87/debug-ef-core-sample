# debug-ef-core-sample  

Sample project that uses the [DebugEFCore Nuget package](https://www.nuget.org/packages/DebugEFCore/)   

[Blogpost with project description](https://www.tddapps.com/2018/03/06/seamlessly-debug-entity-framework-core-sql-commands/)  
[DebugEFCore GitHub Repository](https://github.com/camilin87/debug-ef-core)  

# Sample Output Before `DebugEFCore`  

```
$ dotnet run
2018-04-26 00:32:40 INFO [Program] Started
2018-04-26 00:32:41 INFO [Program] Employees Count Before: 5
2018-04-26 00:32:41 INFO [Program] Employees Count After: 6
2018-04-26 00:32:41 INFO [Program] Finished
```

# Sample Output After `DebugEFCore`  

```
$ dotnet run
2018-04-26 00:34:18 INFO [Program] Started
2018-04-26 00:34:18 INFO [DataContextLoggerProvider] Entity Framework Core 2.0.2-rtm-10011 initialized 'MyDbContext' using provider 'Microsoft.EntityFrameworkCore.Sqlite' with options: None
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (19ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT COUNT(*) FROM "sqlite_master" WHERE "name" = '__EFMigrationsHistory' AND "type" = 'table';
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT COUNT(*) FROM "sqlite_master" WHERE "name" = '__EFMigrationsHistory' AND "type" = 'table';
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT "MigrationId", "ProductVersion"
FROM "__EFMigrationsHistory"
ORDER BY "MigrationId";
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] No migrations were applied. The database is already up to date.
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT COUNT(*)
FROM "Employees" AS "e"
2018-04-26 00:34:19 INFO [Program] Employees Count Before: 6
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (10ms) [Parameters=[@p0='?', @p1='?', @p2='?', @p3='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Employees" ("Age", "FirstName", "LastName", "Title")
VALUES (@p0, @p1, @p2, @p3);
SELECT "Id"
FROM "Employees"
WHERE changes() = 1 AND "Id" = last_insert_rowid();
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
PRAGMA foreign_keys=ON;
2018-04-26 00:34:19 INFO [DataContextLoggerProvider] Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT COUNT(*)
FROM "Employees" AS "e"
2018-04-26 00:34:19 INFO [Program] Employees Count After: 7
2018-04-26 00:34:19 INFO [Program] Finished
```

# Building the project  

```bash
dotnet clean && && dotnet restore && dotnet build
```

# Running the project  

```bash
dotnet run
```
