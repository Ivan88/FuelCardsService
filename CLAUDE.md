# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Status

One GitHub repository containing three independent .NET solutions (services), each in its own folder with its own `.sln`. All projects target `net10.0` with nullable and implicit usings enabled. The projects are freshly scaffolded and mostly empty; there are no tests, README, or lint configuration yet. Update this file as structure emerges.

| Folder | Solution | Projects |
|---|---|---|
| `CardService/` | `CardService.sln` | `CardService.Api` (placeholder `Class1.cs`), `.Domain`, `.Application`, `.Infrastructure` |
| `TransactionService/` | `TransactionService.sln` | `TransactionService.Api` (web API template), `.Domain`, `.Application`, `.Infrastructure` |
| `BillingWorker/` | `BillingWorker.sln` | `BillingWorker.Worker` (worker service template), `.Domain`, `.Application`, `.Infrastructure` |

Each service follows Clean Architecture references: Application → Domain; Infrastructure → Application; Api/Worker → Application + Infrastructure.

## Commands

```
dotnet build CardService/CardService.sln               # likewise TransactionService/, BillingWorker/
dotnet test CardService/CardService.sln                # once a test project exists
dotnet test --filter "FullyQualifiedName~SomeTest"     # run a single test
```

Requires the .NET 10 SDK.
