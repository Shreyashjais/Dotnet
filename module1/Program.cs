using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write()--- writes in same line
        //console.WriteLine()--- Prints the text to the console, and then moves the cursor to the next line.


        //Data Types
        string fName= "Shrey"; 
        int age;
        age=23;    // later declarartion
        char grade= 'A';   // single digit within single quotes
        bool isMale= true;
        float a=4.5f;       //lowest precision
        double b= 4.66;
        decimal c= 4.6667m;  //highest precision


        Console.WriteLine("Hello,My name is "+ fName);
        Console.WriteLine("I am "+ age + " years old.");
        Console.WriteLine(30);   //Constant
        Console.WriteLine("Giraffe \" Academy");     //To print special characters
        Console.WriteLine(grade+ " grade");
        Console.WriteLine(a+ " a " + b+ " b "+c +" c");
        Console.WriteLine(isMale);


        //String
        string phrase="Giraffe academy"+ " is cool."; //String concatenation
        Console.WriteLine(phrase.ToUpper());         //String methods
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.Contains("Academy"));
        Console.WriteLine(phrase[0]);
        Console.WriteLine(phrase.IndexOf("academy"));   //string
        Console.WriteLine(phrase.IndexOf('f'));         //character
        Console.WriteLine(phrase.Substring(8)); 
        Console.WriteLine(phrase.Substring(8,3));

        //Numbers
        Console.WriteLine(3+4*2);
        Console.WriteLine((3+4)*2);
        Console.WriteLine(5.0+8.1);  //decimal
        Console.WriteLine(5+8.1);    //decimal
        Console.WriteLine(5/2);      //Integer 
        Console.WriteLine(5/2.0);   //Decimal

        int num=6;
        num++;
        Console.WriteLine(num);
        num--;
        Console.WriteLine(num);

        Console.WriteLine(Math.Abs(-40)); //Methods
        Console.WriteLine(Math.Pow(2,3)); 
        Console.WriteLine(Math.Sqrt(36));
        Console.WriteLine(Math.Max(5,7));
        Console.WriteLine(Math.Min(5,7));
        Console.WriteLine(Math.Round(5.8));

        //Getting user Input
        Console.Write("Enter your name");
        string name= Console.ReadLine();
        Console.WriteLine("Hello "+ name);
       
    }
    }

