using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Reflection.Emit;

namespace CodeGenerators.Test;


[Generator(LanguageNames.CSharp)]
public class TestGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        System.Diagnostics.Debugger.Launch();
        Debug.WriteLine("generator start");
    }

    public void Execute(GeneratorExecutionContext context)
    {
        Console.WriteLine(1);

        context.Compilation.
        
        var compilation = context.Compilation;
        
        var tryes = compilation.SyntaxTrees;

        foreach (var trye in tryes)
        {
            var root = trye.GetRoot();
            var nodes = root.DescendantNodesAndSelf();

            var classes = nodes
                .Where(ex => ex is ClassDeclarationSyntax)
                .Cast<ClassDeclarationSyntax>();

            var obsolet = classes
                .Where(ex => ex.AttributeLists
                    .Any(ex => ex
                        .GetText(Encoding.UTF8)
                        .ContentEquals(SourceText.From("Obsolete", Encoding.UTF8)))
                ).ToList();

            var attributes = classes.FirstOrDefault() != null ? classes.First().AttributeLists : [];
            
            var descendants = 11;

        }
        
    }
}