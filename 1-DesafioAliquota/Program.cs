class program
{
    static void Main(String[] args)
    {
        Console.Write("Digite seu salario: ");
        double salario = Double.Parse(Console.ReadLine());

        if (salario >= 1900.00 && salario <= 2800.00)
        {
            Console.WriteLine("Sua aliquota e de 7.5%");
            Console.WriteLine("Voce pode deduzir até $142");
        }
        else if (salario >= 2800.01 && salario <= 3751.00)
        {
            Console.WriteLine("Sua aliquota e de 15%");
            Console.WriteLine("Voce pode deduzir ate $350");
        }
        else if (salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("Sua aliquota e de 22.5%");
            Console.WriteLine("Voce pode deduzir ate $636");
        }
    }
}

