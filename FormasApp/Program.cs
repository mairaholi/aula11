using FormasApp.Abstractions;
using FormasApp.Shapes;

namespace FormasApp;

internal class Program
{
    private static readonly Forma[] _formas = new Forma[]
    {
        new Quadrado(),
        new Circulo(),
        new Retangulo()
    };

    private static void Main()
    {
        foreach (var forma in _formas)
            Console.WriteLine(forma.PrintMe());
    }
}