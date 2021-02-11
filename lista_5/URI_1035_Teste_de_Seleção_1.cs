using System;
class MainClass{
  public static void Main (string[] args){
  string valores = Console.ReadLine();
  string[] valores1 = valores.Split(' ');
  int a = int.Parse(valores1[0]);
  int b = int.Parse(valores1[1]);
  int c = int.Parse(valores1[2]);
  int d = int.Parse(valores1[3]);

  //b>c e d>a e soma c+b > soma a+d e c e d positivos

  if(b > c &&  d > a && (a + b) < (c + d) && c > 0 && d > 0)
  Console.WriteLine("Valores aceitos");
  else Console.WriteLine("Valores nao aceitos");
  



  }
}
