//Enunciado: 5.Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.

public class hallarhipotenusa
{


    static void Main(string[] args)
    {
        double catetoO, catetoA, Hipotenusa;

        Console.Write("Ingresar cateto opuesto: ");
        catetoO = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar cateto adyacente: ");
        catetoA = Convert.ToDouble(Console.ReadLine());

        Hipotenusa = Math.Sqrt(Math.Pow(catetoO, 2) + Math.Pow(catetoA, 2));

        Console.Write("La hipotenusa es igual a: " + Hipotenusa);
        Console.Write("\n");

    }

}
