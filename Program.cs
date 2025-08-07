






using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

Console.ForegroundColor = ConsoleColor.Green;




string[] tab = new string[]{"pierre","papier","ciseaux"};
string userChoice;
int userSelect=0;
int choixAdverse=0;
bool victory = false;

int pointsForUser=0;
int pointsForComputer=0;
bool isfinished=false;
bool egality = false;
bool partyOver = false;



//user choices


while (!isfinished) 
{
    Random randChoixAdverse = new Random();


    choixAdverse = randChoixAdverse.Next(2);

    //System.Console.WriteLine(choixAdverse);

    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.WriteLine($"le choix adverse  est {tab[choixAdverse]}");
    Console.ResetColor();



    void display()
    {

        System.Console.WriteLine($"points de l user sont {pointsForUser} ");
        System.Console.WriteLine($"points de l'ordi {pointsForComputer} ");

        System.Console.WriteLine("entrer un numero et choisissez ");
        System.Console.WriteLine(" 0. pierre");
        System.Console.WriteLine(" 1. papier");
        System.Console.WriteLine(" 2. ciseaux");


        userSelect = int.Parse(Console.ReadLine());

    }


    // faire un random qui selectionne le choix de l'adversaire

    void comparaison()
    {

        if (userSelect > -1 && userSelect <= 2)
        {
            userChoice = tab[userSelect];

        }
        else
        {
            System.Console.WriteLine("le nombre doit etre compris entre 0 et 2 , reesayer");
        }


    }

    bool conditionDeVictoire()
    {

        // u = 0 && ad =2
        // u = 1 && ad =0 
        // u = 2 && ad =1 
        // { "pierre","papier","ciseaux"};

        if ((userSelect == 0 && choixAdverse == 2) || (userSelect == 1 && choixAdverse == 0) || (userSelect == 2 && choixAdverse == 1))
        {

            victory = true;
            // System.Console.WriteLine("égalité");

        }
        else if (userSelect == choixAdverse)
        {
           egality = true;


        }
        else
        {
            victory = false;
        }
      







        return victory;

    }




   void comptePoint()
    {

        if (victory)
        {
            pointsForUser += 1;
            Console.WriteLine(pointsForUser.ToString());


        }else if (egality)
        {
            pointsForUser += 1;
            pointsForComputer += 1;



        }else if (!victory)
        {
            pointsForComputer += 1;
        }
        
        



        //else
        //{
        //    pointsForComputer += 1;
        //}



        





        System.Console.WriteLine($"points de l'user sont {pointsForUser} ");
        System.Console.WriteLine($"points de l'ordi sont {pointsForComputer} ");










    }


    void win()
    {


        if (pointsForUser >= 5)
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("l'user win ");
            pointsForComputer = 0;
            pointsForUser = 0;

        }
        else if (pointsForComputer>=5)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("you loose , computer win ");
            Console.WriteLine("game-over!");
            pointsForComputer = 0;
            pointsForUser = 0;
        
        
        }



    }








    display();
    comparaison();
    conditionDeVictoire();
    comptePoint();
    win();

    
    Console.WriteLine("Continue ? o / q");
    string input = Console.ReadLine();
    if (input == "o")
    {
        Console.Clear();
        isfinished = false;

// modifie la conditions de sortie
    }else
    {
        isfinished = true;
    }

  

};






















