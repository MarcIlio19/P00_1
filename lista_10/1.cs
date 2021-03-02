using System;
class MainClass{
  public static void Main(string[] args){
  retangulo x = new retangulo(10,20);
  x.SetBase(10);
  x.SetAltura(20);
  Console.WriteLine(x.CalcArea());
  Console.WriteLine(x.CalcDiagonal());
  Console.WriteLine(x.ToString());


}
class retangulo{
  private double b,h;
  public retangulo(double b, double h){
    if(b > 0) this.b = b;
    if(h > 0) this.h = h;
  }
  public void SetBase(double b){
  if(b > 0) this.b = b;
  }
  public void SetAltura(double h){
  if(h > 0)this.h = h;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }


 public double CalcArea(){
   double area;
   area = b*h;
   return area;
 }
 public double CalcDiagonal(){
   double diagonal;
   diagonal = (b*b) + (h*h);
   return diagonal;
 }

 public override String ToString(){
   return $"sua area é :{CalcArea()} e sua diagonal é: {CalcDiagonal()}";
 }
}
}