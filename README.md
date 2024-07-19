# SharpBoost

SharpBoost is a tool designed to enhance C# development by providing code analysis, refactoring suggestions, code snippets, and performance tips.

## Features

- **Code Analysis**: Analyze C# code for common issues and best practices.
- **Refactoring**: Provide suggestions for code refactoring to improve readability and maintainability.
- **Code Snippets**: Offer a library of commonly used code snippets for quick insertion.
- **Performance Tips**: Suggest performance optimizations.

## Getting Started

### Prerequisites

- .NET SDK
- Visual Studio or any other C# IDE

### Installation

1. Clone the repository:
```bash
git clone https://github.com/VoltagedDebunked/SharpBoost.git
cd SharpBoost
```
2. Install the required NuGet packages:
```bash
dotnet add package Microsoft.CodeAnalysis
dotnet add package Microsoft.CodeAnalysis.CSharp
dotnet add package Microsoft.Build.Locator
dotnet add package Microsoft.CodeAnalysis.Workspaces.MSBuild
```
### Usage

1. Build the project:
```bash
dotnet build
```
2. Run the tool with your solution path:
```bash
dotnet run -- <path-to-your-solution>
```
### Example

To analyze a solution located at `C:\Projects\MySolution.sln`, run:
```bash
dotnet run -- C:\Projects\MySolution.sln
```

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the Apache 2.0 License - see the [LICENSE file](LICENSE) for details.
