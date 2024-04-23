using csharp_vetores_exercicios;

Hospede[] hospedes = new Hospede[10];
int resp = 0;

while (resp != 3)
{
    Console.WriteLine("Programa da pensão");
    Console.WriteLine("==================\n");
    Console.Write("Digite 1 para adicionar um hóspede, 2 para listar os hóspedes ou 3 para sair: ");
    resp = int.Parse(Console.ReadLine());
    switch (resp)
    {
        case 1:
            AdicionarHospede();
            break;
        case 2:
            ListarHospedes();
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Insira um valor válido");
            break;
    }
}
void AdicionarHospede()
{
    Console.Clear();
    Console.Write("Qual quarto foi reservado? ");
    int quarto = int.Parse(Console.ReadLine());
    Console.Write("Digite o nome do hóspede: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o email do hóspede: ");
    string email = Console.ReadLine();
    hospedes[quarto - 1] = new Hospede { Email = email, Quarto = quarto, Nome = nome };
    if (hospedes[quarto - 1] != null)
    {
        Console.WriteLine("Registro realizado com sucesso\n");
        Console.WriteLine("==============================");
    } else
    {
        Console.WriteLine("Algo deu errado no seu registro\n");
        Console.WriteLine("===============================");
    }
    Console.Write("Deseja registrar outro hóspede? (s/n): ");
    string resp = Console.ReadLine().ToLower();
    if (resp == "s")
    {
        AdicionarHospede();
    }
    Console.Clear();
}

void ListarHospedes()
{
    Console.Clear();
    for(int i = 0; i < 10; i++)
    {
        if (hospedes[i] != null)
        {
            Console.WriteLine(hospedes[i]);
        }
    }
    Console.WriteLine("================================");
    Console.Write("Pressione 'enter' para prosseguir: ");
    Console.ReadLine();
    Console.Clear();
}