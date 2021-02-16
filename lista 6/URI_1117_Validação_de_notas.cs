using System; 

class MainClass {

    static void Main(string[] args) { 

        int notasvalidas = 0;
    double soma = 0;
    while( notasvalidas < 2)
    {
      double nota = double.Parse(Console.ReadLine());
      if (nota < 0 || nota > 10)
      Console.WriteLine("nota invalida");
      
      else{
        notasvalidas++;
        soma += nota;
      }
    }
    double media = soma/ notasvalidas;
    string media1 = media.ToString("0.00");
    Console.WriteLine($"media = {media1}");

    }

}