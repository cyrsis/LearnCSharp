using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Roslyn
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = File.ReadAllText("code.cs");
            var tree = SyntaxFactory.ParseSyntaxTree(code);

            var compilation = CreateCompilation(tree);
            var model = compilation.GetSemanticModel(tree);            

            ShowLocalDeclarations(tree, model);
            ShowDiagnostics(compilation);
            ExecuteCode(compilation);

        }

        private static void ShowLocalDeclarations(SyntaxTree tree, SemanticModel model)
        {
            var locals = tree.GetRoot()
                             .DescendantNodes()
                             .OfType<LocalDeclarationStatementSyntax>();

            foreach (var node in locals)
            {
                var type = model.GetTypeInfo(node.Declaration.Type);
                Console.WriteLine("{0} {1}", type.Type, node.Declaration);
            }
        }

        private static void ExecuteCode(CSharpCompilation compilation)
        {
            using (var stream = new MemoryStream())
            {
                compilation.Emit(stream);

                var assembly = Assembly.Load(stream.GetBuffer());
                var type = assembly.GetType("Greeter");
                var greeter = Activator.CreateInstance(type);
                var method = type.GetMethod("SayHello");
                method.Invoke(greeter, null);
            }
        }

        private static void ShowDiagnostics(CSharpCompilation compilation)
        {
            var diagnostics = compilation.GetDiagnostics();
            foreach (var diagnostic in diagnostics)
            {
                Console.WriteLine(diagnostic.ToString());
            }
        }

        private static CSharpCompilation CreateCompilation(SyntaxTree tree)
        {
            var options = new CSharpCompilationOptions(
                                            OutputKind.DynamicallyLinkedLibrary);

            var reference = new MetadataFileReference(typeof(object).Assembly.Location);

            var compilation =
                CSharpCompilation.Create("test")
                                 .WithOptions(options)
                                 .AddSyntaxTrees(tree)
                                 .AddReferences(reference);
            return compilation;
        }
    }
}
