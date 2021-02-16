using System; 

class URI {

    static void Main(string[] args) { 

        int x = 0;
    

   
    int teste = int.Parse(Console.ReadLine());
    while(x <= teste)
    
    {
    x++;
    int divisores = 0;
    int valor = int.Parse(Console.ReadLine());
    for( int começo = 1; começo <= valor; começo++)
    {
      
    if(valor % começo == 0 )
    divisores++;
    }
    if (divisores == 2)
    Console.WriteLine("Prime");
    
    else
    {
    Console.WriteLine("Not Prime");
    }
    }
    

    }

}