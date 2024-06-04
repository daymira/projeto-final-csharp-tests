using Calculadora.Services;

CalculadoraBasica calc = new CalculadoraBasica();

Console.WriteLine(" Calculadora Básica");

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    Console.WriteLine("Digite a opção desejada.\n"+
                      "1 - Somar.\n"+
                      "2 - Subtrair.\n"+
                      "3 - Multiplicar.\n"+
                      "4 - Dividir.\n" +
                      "5 - Porcentagem.\n" +
                      "6 - Histórico.\n" +
                      "7 - Encerrar Programa.\n");

    switch(Console.ReadLine()){
        case "1":
            Console.Write("1°: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("2°: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n1} + {n2} = {calc.Somar(n1,n2)}");
            break;
        case "2":
            Console.Write("1°: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2°: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n1} - {n2} = {calc.Subtrair(n1,n2)}");
            break;
        case "3":
            Console.Write("1°: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2°: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n1} * {n2} = {calc.Multiplicar(n1,n2)}");
            break;
        case "4":
            Console.Write("1°: ");
            decimal p1 = Decimal.Parse(Console.ReadLine());
            Console.Write("2°: ");
            decimal p2 = Decimal.Parse(Console.ReadLine());
            try
            { 
                Console.WriteLine($"{p1} / {p2} = {calc.Dividir(p1,p2)}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            break;
        case "5":
            Console.Write("O número que deseja saber a porcentagem: ");
            p1 = Decimal.Parse(Console.ReadLine());
            Console.Write("Porcentagem: ");
            p2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{p2}% de {p1} = {calc.Porcentagem(p1,p2)}");
            break;
        case "6":
            List<string> historico = calc.Historico();
            if (historico.Count == 0)
            {
                Console.WriteLine("Nenhuma operação realizada ainda.");
            }
            else
            {
                Console.WriteLine("Histórico:");
                foreach (string entry in historico)
                {
                    Console.WriteLine(entry);
                }
            }
            break;
        case "7":
            exibirMenu = false;
            break;
        default:
        Console.WriteLine("Opção inválida.");
        break;
    }
    Console.WriteLine("Aperte enter para continuar.");
    Console.ReadLine();
}
Console.WriteLine("Programa encerrado.");
