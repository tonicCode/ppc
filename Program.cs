






//*********************************************style des chiffres et des lettres********************************


//afficher chiffres principales 



//1 random dix chiffres 
using System.Globalization;
using System.Runtime.CompilerServices;

Random randNumberList = new Random();


//2 les afficher
for (int i = 0; i < 10; i++)
{
    // Console.Write("");
    Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(" "+ randNumberList.Next(100));


}






//afficher resultat à obtenir
Random randGetNumber = new Random();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(" ");
System.Console.Write($"le nombre final à obtenir est {randGetNumber.Next(2000)}" );
Console.ResetColor();


//creer la calculette
string operat = "";



void calculette( int a, int b, string operat, int result )
{


    System.Console.WriteLine("entrer le 1er chiffre ");
   a=int.Parse(Console.ReadLine());
   System.Console.WriteLine("entrer l'operation");
    operat = Console.ReadLine();
    Console.WriteLine("entrer le second");
    b = int.Parse(Console.ReadLine());
    



switch (operat)
    {

        case "+":
            result = a + b;
            result.ToString();
            break;

        case "-":
        
           result= a - b;
           result.ToString();
            break;



        case "*":
        
          result= a * b;
          result.ToString();
            break;


        case "/":

            result = a / b;
           result.ToString();
            break;




    }
    calculette(a,b,operat,result);
}



