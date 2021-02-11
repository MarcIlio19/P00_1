

using System;
class MainClass{
public static void Main(string[] args){
string[] valores = Console.ReadLine().Split(' ');
int valor1 = int.Parse(valores[0]);
int valor2 = int.Parse(valores[1]);
int valor3 = int.Parse(valores[2]);
int valor4 = int.Parse(valores[3]);
int valor5 = int.Parse(valores[4]);
int valor6 = int.Parse(valores[5]);

string[] valores1 = Console.ReadLine().Split(' ');
int valor12 = int.Parse(valores1[0]);
int valor22 = int.Parse(valores1[1]);
int valor32 = int.Parse(valores1[2]);
int valor42 = int.Parse(valores1[3]);
int valor52 = int.Parse(valores1[4]);
int valor62 = int.Parse(valores1[5]);

int x = 0;

if(valor1 == valor12 ||valor1 == valor22 ||valor1 == valor32 ||valor1 == valor42 ||valor1 == valor52 ||valor1 == valor62 )
x++;

if(valor2 == valor12 ||valor2 == valor22 ||valor2 == valor32 ||valor2 == valor42 ||valor2 == valor52 ||valor2 == valor62 )
x++;

if(valor3 == valor12 ||valor3 == valor22 ||valor3 == valor32 ||valor3 == valor42 ||valor3 == valor52 ||valor3 == valor62 )
x++;


if(valor4 == valor12 ||valor4 == valor22 ||valor4 == valor32 ||valor4 == valor42 ||valor4 == valor52 ||valor4 == valor62 )
x++;

if(valor5 == valor12 ||valor5 == valor22 ||valor5 == valor32 ||valor5 == valor42 ||valor5 == valor52 ||valor5 == valor62 )
x++;

if(valor6 == valor12 ||valor6 == valor22 ||valor6 == valor32 ||valor6 == valor42 ||valor6 == valor52 ||valor6 == valor62 )
x++;

if (x == 3)
Console.WriteLine("terno");
if (x == 4)
Console.WriteLine("quadra");
if (x == 5)
Console.WriteLine("quina");
 if (x == 6)
Console.WriteLine("sena");
if (x < 3)
Console.WriteLine("azar");
  }
}

