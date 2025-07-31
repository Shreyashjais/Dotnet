
using System;
    class Program{
        static void Main(string[] args){
          PrintNumbers(8);
          PrintNums(6);
          PrintingNums(9);

          Console.WriteLine("Please enter a word");
          string answer= Console.ReadLine();
          GuessWord(answer);
        
        }

        //While Loop
        static void PrintNumbers(int index){
            int i=1;
            while(i<=index){
                Console.WriteLine(i);
                i++;
            }
            
        }

        //Do while loop
        static void PrintNums(int index){
            int i=1;
            do{
             Console.WriteLine(i);
            }
            while(index<=5);
        }

        //For loop
        static void PrintingNums(int limit){
            for(int i=1; i<=limit; i++){
                Console.WriteLine(i);
            }
        }

        //guessing game
        static void GuessWord(string word){
            string ans= "Giraffe";
            while(ans != word){
                Console.WriteLine("Please guess the word again.");
                word=Console.ReadLine();
            }
            Console.WriteLine("You won!");
        }


        static int GetPow(int)
    }
