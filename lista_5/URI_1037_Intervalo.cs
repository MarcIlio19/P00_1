using System;
class MainClass{
  public static void Main(string[]ags){
    //ler um valor de ponto flutuante e dizer em qual  intervalo  ele esta [0,25] (25,50], (50,75], (75.100];
    double valor = double.Parse(Console.ReadLine());
    if(0 <= valor && valor <= 25.000)
    Console.WriteLine("Intervalo [0,25]");
    if (25 < valor && valor <= 50.000)
    Console.WriteLine("Intervalo (25,50]");
    
    if(50.000 < valor && valor <= 75)
    Console.WriteLine("Intervalo (50,75]");
    if(75 < valor && valor <= 100.000)
    Console.WriteLine("Intervalo (75,100]");
    if (0 > valor || valor > 100.000)
    Console.WriteLine("Fora de intervalo");

  }
}