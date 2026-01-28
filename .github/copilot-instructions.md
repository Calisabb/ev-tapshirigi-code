# AI Coding Agent Instructions for MyFirstCSharp

## Project Overview

**MyFirstCSharp** is a simple .NET 10.0 console application demonstrating basic C# syntax and logic.

- **Language**: C# (.NET 10.0)
- **Project Type**: Console Application
- **Entry Point**: [Program.cs](../Program.cs) - contains simple arithmetic and conditional logic
- **Build System**: MSBuild (via .NET CLI)

## Project Structure

- `Program.cs` - Single entry point with basic integer arithmetic and if/else logic
- `MyFirstCSharp.csproj` - Project configuration defining .NET 10.0 target and C# features
- `bin/Debug/` - Build output directory (do not edit manually)
- `obj/` - Intermediate build artifacts (do not edit manually)

## Key Configuration

**Enable Features** (`MyFirstCSharp.csproj`):
- **ImplicitUsings**: Enabled - common .NET namespaces auto-imported (System, System.Collections.Generic, etc.)
- **Nullable**: Enabled - strict null-safety checks enforced

These settings mean all code should handle nullable reference types and avoid explicit `using` statements for common namespaces.

## Build & Execution

**Build**:
```bash
dotnet build
```

**Run**:
```bash
dotnet run
```

**Run from build output**:
```bash
.\bin\Debug\net10.0\MyFirstCSharp.exe
```

## Code Patterns

### Current Program Logic
The entire application sums two integers (5 + 6) and validates the result:
- Adds without intermediate variables where possible
- Uses simple if/else for control flow
- Outputs "good" or "bad" based on arithmetic validation

### When Adding Code
- Use `Console.WriteLine()` for output (no additional namespaces needed due to ImplicitUsings)
- Keep logic simple unless explicitly extending functionality
- Follow .NET naming conventions: `PascalCase` for methods/classes, `camelCase` for local variables
- Always consider nullable reference types in method signatures

## Integration Points

This is a standalone console app with no external dependencies beyond the .NET runtime. All logic is self-contained in Program.cs.

## Debugging Notes

- Program runs synchronously with immediate console output
- No error handling currently - failures will throw unhandled exceptions
- Output is always to stdout via Console.WriteLine()
