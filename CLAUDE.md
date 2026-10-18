# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Status

Freshly scaffolded .NET solution. `FuelCardsService.sln` contains four projects, all targeting `net10.0` with nullable and implicit usings enabled: `FuelCardsService.Api` (holds an empty placeholder `Class1.cs`), and the empty class libraries `FuelCardsService.Domain`, `FuelCardsService.Application` and `FuelCardsService.Infrastructure`. Project references follow Clean Architecture: Application → Domain; Infrastructure → Application; Api → Application + Infrastructure. There are no tests, README, or lint configuration yet. Update this file as structure emerges.

## Commands

```
dotnet build FuelCardsService.sln
dotnet test FuelCardsService.sln                       # once a test project exists
dotnet test --filter "FullyQualifiedName~SomeTest"     # run a single test
```

Requires the .NET 10 SDK.
