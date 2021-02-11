using System;
class MainClass{
  public static void Main(string[] args){
    
  string[] valores = Console.ReadLine().Split(" ");
  int valor1 = int.Parse(valores[0]);
  int valor2 = int.Parse(valores[1]);
  int valor3 = int.Parse(valores[2]);
  int valor4 = int.Parse(valores[3]);
  int valor5 = int.Parse(valores[4]);

  if(valor1 < valor2 && valor2 < valor3 && valor3 < valor4 && valor4 < valor5)
  Console.WriteLine("C");

  else if (valor1 > valor2 && valor2 > valor3 && valor3 > valor4 && valor4 > valor5)
  Console.WriteLine("D");

  else
  Console.WriteLine("N");
  
 
  }
  }