using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            // Console.WriteLine("i'm learning c#");
            
            // on va voir les type de variable
            int myNum = 5;              // Integer (whole number)
            double myDoubleNum = 5.99D; // Floating point number
            char myLetter = 'D';       // Character
            bool myBool = true;        // Boolean
            string myText = "Hello";    // String
            // end
            
            // constantes
            const int myAge = 21;
            // myAge = 34; // erreur
            // end
            
            // les input
            //  Console.WriteLine("Enter username:"); // on demande a l'utilisateur d'entrer son nom
            string UserName = Console.ReadLine(); // on stock le nom dans la variable UserName de type string
            //   Console.WriteLine("Username is: " + UserName); // on affiche le nom
            
            //  Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); // on converti le string en int
           //  Console.WriteLine("Your age is: " + age);
            
            // end
            
            // les opérateurs  
            int x = 100 + 50;
            int y = x - 50; 
            int z = x * 2;
            int a = x / 2;
            int b = x % 3;
            // end
            
            // maths 
            Math.Max(5, 10);  // returns 10
            Math.Min(5, 10);  // returns 5
            Math.Sqrt(64);    // returns 8
            Math.Abs(-4.7);   // returns 4.7
            Math.Round(9.99); // returns 10
            // end
            
            // les strings
            string txt = "Hello World";
            // Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            // Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            // Console.WriteLine(txt.Length);      // Outputs 11
            //end
            
            // conditions
            int time = 20;
            if (time < 18) {
                Console.WriteLine("Good day.");
            } else {
                Console.WriteLine("Good evening.");
            }
            // end
            
            // switch
            int day = 4;
            switch (day) {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend");
                    break;
            }
            // end
            
            // boucle for       
            
            int i;
            for (i = 0; i < 5; i++) { // on initialise i a 0, on dit que tant que i est inferieur a 5 on execute le code et on ajoute 1 a i
                Console.WriteLine(i);  // on affiche i a chaque tour de boucle
            }
            // end
            
            // boucle while
            i = 0;
            while (i < 5) {
                Console.WriteLine(i);
                i++;
            }
            // end

            do
            { 
                Console.WriteLine(i);
              i++;
              
            } while (i < 5);
            
            // end
            
            // tableau  
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            int[] myNums = {10, 20, 30, 40};
            Console.WriteLine(cars[0]); // Outputs Volvo
            Console.WriteLine(myNums[2]); // Outputs 30
            cars[0] = "Opel";
            Console.WriteLine(cars.Length); // Outputs 4
            i = 0;
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i]); // Outputs all elements in cars array   
// end
            
            // boucle foreach
            i = 0;
            foreach (string i in cars)
            {
                    Console.WriteLine(i);
            }
                
            // end
        }
        
    }
}