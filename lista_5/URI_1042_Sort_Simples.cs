using System;
class MainClass {
  public static void Main (string[] args){
  string[] valores = Console.ReadLine().Split(' ');
  int a = int.Parse(valores[0]);
  int b = int.Parse(valores[1]);
  int c = int.Parse(valores[2]);
  //a>b>c
  if(a > b && b > c)
  {
  Console.WriteLine(c);
  Console.WriteLine(b);
  Console.WriteLine(a);

  Console.WriteLine(" ");
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  }
//se b>a>c
  if(b > a && a > c)
  {
  Console.WriteLine(c);
  Console.WriteLine(a);
  Console.WriteLine(b);

  Console.WriteLine(" ");
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  }
//c>b>a
  if(c > b && b > a)
  {
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);

  Console.WriteLine(" ");
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  }
//c>a>b
  if(c > a && a > b)
  {
  Console.WriteLine(b);
  Console.WriteLine(a);
  Console.WriteLine(c);

  Console.WriteLine(" ");
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  }
//a>c>b
  if(a > c && c > b)
  {
  Console.WriteLine(b);
  Console.WriteLine(c);
  Console.WriteLine(a);

  Console.WriteLine(" ");
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  }

  if(b > a && c > a)
  {
  Console.WriteLine(a);
  Console.WriteLine(c);
  Console.WriteLine(b);

  Console.WriteLine(" ");
  Console.WriteLine(b);
  Console.WriteLine(c);
  Console.WriteLine(a);
  }
  
}
}