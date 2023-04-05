//1. Receber nome diferente de vazio;
//2. Receber Idade entre 0 e 100;
//3. Receber salário maior que zero;
//4. Estado Civil 'S' Solteiro, 'C' Casado, 'V' Viuvo, 'D' Divorciado.



Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

while (String.IsNullOrEmpty(nome))
{
    Console.WriteLine($"Informe um nome com uma ou mais caracteres, para prosseguir... ");
    nome = Console.ReadLine(); 
}

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100 )
{
    Console.WriteLine($"Informe uma idade válida para prosseguir, de 0 a 100 ");
    idade = int.Parse(Console.ReadLine()); 
}

Console.WriteLine($"Informe o seu salário: ");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0 )
{
    Console.WriteLine($"Tente novamente e informe um salário válido...");
    salario = float.Parse(Console.ReadLine()); 
}

Console.WriteLine($"Informe seu estado civil atual com (S) para Solteiro, (C) Casado, (V) Viuvo, (D) Divorciado");
char estadoCivil = char.Parse(Console.ReadLine());

while (estadoCivil != 'S' && estadoCivil != 'C' && estadoCivil != 'V' && estadoCivil != 'D' )
{
    Console.WriteLine($"Tente novamente e informe o estado civil como pedido no enunciado...");
    estadoCivil = char.Parse(Console.ReadLine()); 
}

Console.WriteLine($"Obrigado pelo seu cadastro!");





