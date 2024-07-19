using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

namespace SharpBoost
{
    public class CodeAnalyzer
    {
        public static async Task AnalyzeCodeAsync(string solutionPath)
        {
            using (var workspace = MSBuildWorkspace.Create())
            {
                var solution = await workspace.OpenSolutionAsync(solutionPath);
                foreach (var project in solution.Projects)
                {
                    foreach (var document in project.Documents)
                    {
                        var syntaxTree = await document.GetSyntaxTreeAsync();
                        var root = await syntaxTree.GetRootAsync();

                        var diagnostics = AnalyzeSyntax(root);
                        PrintDiagnostics(diagnostics, document.Name);
                    }
                }
            }
        }

        private static List<string> AnalyzeSyntax(SyntaxNode root)
        {
            var diagnostics = new List<string>();

            // Example: Suggest using var for local variable declarations
            var localDeclarations = root.DescendantNodes().OfType<LocalDeclarationStatementSyntax>();
            foreach (var declaration in localDeclarations)
            {
                if (declaration.Declaration.Type is PredefinedTypeSyntax)
                {
                    diagnostics.Add($"Consider using 'var' for variable declaration at {declaration.GetLocation().GetLineSpan().StartLinePosition}");
                }
            }

            return diagnostics;
        }

        private static void PrintDiagnostics(List<string> diagnostics, string documentName)
        {
            Console.WriteLine($"Analysis for {documentName}:");
            foreach (var diagnostic in diagnostics)
            {
                Console.WriteLine(diagnostic);
            }
        }
    }
}