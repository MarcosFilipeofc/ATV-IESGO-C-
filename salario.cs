using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nome do funcionário");
        string Nome_f = Console.ReadLine();
        Console.WriteLine("Horas trabalhadas");
        int horas_trab = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Taxa de pagamento por hora");
        double tax_pag = Convert.ToInt32(Console.ReadLine());
        
        

        Console.WriteLine("Valor das suas comissões semanais");
        
        decimal comissoeee = Convert.ToInt32(Console.ReadLine());



        decimal salario_brute = (decimal)(horas_trab * tax_pag) + comissoeee; 
        

        Console.WriteLine($"Funcionario -  {Nome_f}");
        
        Console.WriteLine($"O salario do Funcionario é  {salario_brute}");  
    }
}
