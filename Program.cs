Console.Clear();

double gasolina, comparacao, alcool;
 
Console.WriteLine("ALCOOL ou GASOLINA\n");
 
Console.Write("Digite o preço do álcool:");
alcool = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Digite o preço da gasolina:");
gasolina = Convert.ToDouble(Console.ReadLine());
 
comparacao = (alcool / gasolina) * 100;
 
Console.WriteLine($"O preço do alcool corresponde a {comparacao}% do preço da gasolina.");
 
if (comparacao <= 73)
 
  {
     Console.ForegroundColor = ConsoleColor.DarkYellow;
     Console.WriteLine("Recomendação: Abasteça com ALCOOL.");
     Console.ResetColor();
  }
 
else
 
  { 
   Console.ForegroundColor = ConsoleColor.DarkRed;
   Console.WriteLine( "Recomendação: Abasteça com GASOLINA.");
   Console.ResetColor();
  }