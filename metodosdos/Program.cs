using System;

class Program
{
    static void Main()
    {
        Ejemplo instancia = new Ejemplo();
        instancia.MetodoDeInstancia();

        Ejemplo.MetodoEstatico();

        instancia.MetodosAvanzados();
    }
}

class Ejemplo
{
    public static void MetodoEstatico()
    {
        Console.WriteLine("Método estático");
    }

    public void MetodoDeInstancia()
    {
        Console.WriteLine("Método de instancia");
    }

    public void MetodosAvanzados()
    {
        // Llamar al método con expresión lambda para multiplicar por dos
        Func<int, int> MultiplicarPorDos = x => x * 2;
        int resultadoMultiplicacion = MultiplicarPorDos(4);
        Console.WriteLine("Resultado de la multiplicación por dos (lambda): " + resultadoMultiplicacion);

        // Llamar al método con paso por valor
        int valorOriginal = 10;
        Console.WriteLine("Antes del método (paso por valor): " + valorOriginal);
        MetodoPasoPorValor(valorOriginal);
        Console.WriteLine("Después del método (paso por valor): " + valorOriginal);

        // Llamar al método con paso por referencia
        int valorOriginalRef = 10;
        Console.WriteLine("Antes del método (paso por referencia): " + valorOriginalRef);
        MetodoPasoPorReferencia(ref valorOriginalRef);
        Console.WriteLine("Después del método (paso por referencia): " + valorOriginalRef);
    }

    static void MetodoPasoPorValor(int x)
    {
        x = x * 2;
        Console.WriteLine("Dentro del método (paso por valor): " + x);
    }

    static void MetodoPasoPorReferencia(ref int x)
    {
        x = x * 2;
        Console.WriteLine("Dentro del método (paso por referencia): " + x);
    }


}