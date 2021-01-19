using System;
class MainClass {
  public static void Main (string[] args){  
  
string[] valores = Console.ReadLine().Split(' ');
double A = double.Parse(valores[0]);
double B = double.Parse(valores[1]);
double C = double.Parse(valores[2]);
double pi = 3.14159;


double triangulo = (A*C)/2 ;
string triangulo1 = triangulo.ToString("0.000");
Console.WriteLine($"TRIANGULO: {triangulo1}");

double circulo = pi*(C*C);
string circulo1 = circulo.ToString("0.000");
Console.WriteLine($"CIRCULO: {circulo1}");

double trapezio = (A+B)*(C/2);
string trapezio1 = trapezio.ToString("0.000");
Console.WriteLine($"TRAPEZIO: {trapezio1}");

double quadrado = B*B;
string quadrado1 = quadrado.ToString("0.000");
Console.WriteLine($"QUADRADO: {quadrado1}");

double retangulo = A*B;
string retangulo1 = retangulo.ToString("0.000");
Console.WriteLine($"RETANGULO: {retangulo1}");
 
}
 }












