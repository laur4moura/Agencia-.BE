using System.ComponentModel;
using Exercicio2;

Console.Clear();


List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    
System.Console.WriteLine($"Menu de Opções:");
System.Console.WriteLine($@"
1) Cadastrar Faturas
2)Cadastrar Relatório
3)Cadastrar Contrato
4)Listar Faturas
5)Listar Relatórios
6)Listar Contratos
0)Sair
ESCOLHA UMA OPÇÃO:");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    System.Console.WriteLine($"Cadastrar Fatura");
    break;
    
    case 2:
    System.Console.WriteLine($"Cadastrar Relatorio");
    break;
    
    case 3:
    System.Console.WriteLine($"Cadastrar Contrato");
    break;
    
    case 4:
    System.Console.WriteLine($"Listar Fatura");
    break;
    
    case 5:
    System.Console.WriteLine($"Listar Relatorio");
    break;
    
    case 6:
    System.Console.WriteLine($"Listar Contrato");
    break;

    case 0:
    System.Console.WriteLine($"Sair");
    break;
    
    default:
    System.Console.WriteLine($"opcao Invalida");
    break;
}

System.Console.WriteLine($"Digite <Enter> para continuar");
Console.ReadLine();

} while (opcao != 0);


//funções Auxiliares

void CadastrarFatura()
{
    System.Console.WriteLine($"Digite o nome do Devedor");
    string dev = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome do Credor:");
    string cre= Console.ReadLine();
    System.Console.WriteLine($"Digite o valor da Fatura:");
    float valFat =float.Parse(Console.ReadLine());
    System.Console.WriteLine($"Quantos dias a fatura está em atraso?");
    int qntdAtraso= int.Parse(Console.ReadLine());


    Fatura f = new Fatura (dev, cre, valFat, qntdAtraso);
    documentos.Add(f);

     System.Console.WriteLine($"Fatura cadastrado com sucesso");
}

void CadastrarContrato()
{
    System.Console.WriteLine($"Digite o nome do Contratante:");
    string contratante = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome da Contratada");
    string contratada = Console.ReadLine();
    System.Console.WriteLine($"Escreva a sua Claúsulas:");
    string txtClausulas= Console.ReadLine();

    Contrato C = new Contrato(contratante,contratada,txtClausulas);
    documentos.Add(C);

    System.Console.WriteLine($"Contrato cadastrado com sucesso");
}

void CadastrarRelatorio()
{
    System.Console.WriteLine($"Digite o nome do Responsável:");
    string responsavel = Console.ReadLine();
    System.Console.WriteLine($"Escreva o seu Relatório");
    string txtRelatorio = Console.ReadLine();

    Relatorio R = new Relatorio(responsavel,txtRelatorio);
    documentos.Add(R);

    System.Console.WriteLine($"Relatorio cadastrado com sucesso");
}


void ListarFaturas()
{
    System.Console.WriteLine($"Listando as Faturas");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContratos()
{
    System.Console.WriteLine($"Listando osContratos");
     foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
    
}

void ListarRelatorios()
{
    System.Console.WriteLine($"Listando os Relatórios");
     foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
    
}





// Cria uma lista de objetos Fatura

// Fatura fatLaura = new Fatura ("Laura", "Izabel Dark Lab", 50, 1);
 
// fatLaura.Imprimir();

// Relatorio RelLaura = new Relatorio("Laura Kauany", "O desempenho da equipe superou as expectativas, garantindo qualidade e eficiência, As metas do projeto foram realizadas dentro do prazo estabelecido");

// RelLaura.Imprimir();

