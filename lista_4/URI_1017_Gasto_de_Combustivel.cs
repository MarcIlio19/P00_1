using System;
class MainClass {
  public static void Main (String[] str){
  //o carro gasta 12km/L
  //
  double a,b;
  double c;
  string d;
  a = double.Parse(Console.ReadLine());
  b = double.Parse(Console.ReadLine());
  c = (a*b)/12;
  d = c.ToString("0.000");
  Console.WriteLine(d);




  }
  
}
