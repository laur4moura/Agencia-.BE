using ClassesEObjetos;

//CRIAR UM CLASSE PARA REPRESENTAR UMA GARRAFA
//PROPRIEDADES
//MÉTODOS

// GarrafaPet g1 = new GarrafaPet();
// g1.marca = "Gocase";
// g1.material = "inox";
// g1.cor = "Preta";
// g1.volume = 750;
// g1.Abrir();
// g1.Fechar();

// System.Console.WriteLine();
// System.Console.WriteLine($"Características");
// System.Console.WriteLine();

// System.Console.WriteLine($"-----{g1.marca}-----");
// System.Console.WriteLine($"Carro:{g1.marca}");
// System.Console.WriteLine($"Modelo: {g1.material}");
// System.Console.WriteLine($"Cor: {g1.cor}");
// System.Console.WriteLine($"Quantidade de Rodas: {g1.volume}");
// System.Console.WriteLine();
// System.Console.WriteLine($"----");

// Console.Clear();
// GarrafaPet g1 = new GarrafaPet();
// System.Console.WriteLine($"====BEM-VINDO====");
// System.Console.WriteLine();
// System.Console.WriteLine($"Crie uma garrafa agora!");
// System.Console.WriteLine($"Digite o nome do usuário");
// g1.nomeUsuario = Console.ReadLine();
// System.Console.WriteLine();


// System.Console.WriteLine($"Qual a capacidade dessa garrafa?");
// g1.volume = double.Parse(Console.ReadLine());

// System.Console.WriteLine();
// System.Console.WriteLine("Qual o material dessa garrafa?");
// g1.material = Console.ReadLine();

// System.Console.WriteLine();
// System.Console.WriteLine("Qual a cor dessa garrafa?");
// g1.cor = Console.ReadLine();

// System.Console.WriteLine();
// System.Console.WriteLine($"-----{g1}-----");
// System.Console.WriteLine($"Capacidade: {g1.volume} L");
// System.Console.WriteLine($"Tipo: {g1.material}");
// System.Console.WriteLine($"Cor: {g1.cor}");
// System.Console.WriteLine();

//Agencia Bancaria

ContaBancaria Cb1 = new ContaBancaria();


System.Console.WriteLine("=== BEM-VINDO ===");

Console.Write("Digite o nome do titular: ");
Cb1.titular = Console.ReadLine();

Console.Write("Digite o valor para depósito: ");
double valorDeposito = double.Parse(Console.ReadLine());
Cb1.Depositar(valorDeposito);

Console.Write("Digite o valor para saque: ");
double valorSaque = double.Parse(Console.ReadLine());
Cb1.Sacar(valorSaque);

Console.WriteLine($"Saldo final de {Cb1.titular}: R${Cb1.saldo:F2}");

// Pessoa joao = new Pessoa();

// joao.Nome = "joão Silva";
// System.Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novIdade = joao.Envelhecer(17);//atualiza e devolve a idade
// System.Console.WriteLine($"{joao.Nome} tem {novIdade} anos ");

// novIdade = joao.Envelhecer(-50);//devolve a idade antiga:17
// System.Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
