using System;
class Program{
    static void Main(string[] args){
      Greet("Shrey", 12);
      int ans= Cube(3);
      Console.WriteLine(ans);

      //If Statement
      bool isMale= false;
      bool isTall= true;
      if(isMale && isTall){
        Console.WriteLine("You are male and tall.");
      }
      else if(!isMale && isTall){
        Console.WriteLine("You are not male but you're tall.");
      }
      else{
        Console.WriteLine("You are female.");
      }


      Console.WriteLine(GreatestNum(5,6));


    }

    //Methods
    static void Greet(string name, int age){
        Console.WriteLine("Hello "+ name+", how are you?" + " You are " + age);
    }

    //Method with return value
    static int Cube(int num){
        int result= num*num*num;
        return result;
    }

    //Greatest of two numbers
    static int GreatestNum(int a, int b){
        if(a>b){
            return a;
        }
        else{
            return b;
        }
    }
}

