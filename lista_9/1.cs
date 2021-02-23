
using System;
class MainClass{
  public static void Main(string[] args){
  calcircunferencia y = new calcircunferencia();
  y.setraio(double.Parse(Console.ReadLine()));
  Console.WriteLine(y.circunferencia());
  }
}
class calcircunferencia{
  private double raio;
  public void setraio(double v ){
  if(v > 0)
    raio = v;
  }
  public double getraio(){
  return raio;
  }

  public double circunferencia(){
   double circunferencia = raio * 2;
    return  circunferencia;
  }
 
}