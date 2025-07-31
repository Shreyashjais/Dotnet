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

      Console.WriteLine(Calculator("%", 6,4));

      Console.WriteLine(GetDay(4));


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

    //Calculator
    static int Calculator(string op, int num1, int num2){
      if(op == "+"){
        return num1+num2;
      }
      else if(op == "-"){
        return num1-num2;
      }
      else if(op == "*"){
        return num1*num2;
      }
      else if(op== "/"){
        return num1/num2;
      }
      else {
        return num1%num2;
      }
     
    }


    //Switch Case

    static string GetDay(int dayNum){
      string dayName;
      switch(dayNum){
        case 0 :
        dayName="Sunday";
        break;

        case 1:
        dayName="Monday";
        break;

        case 2:
        dayName="Tuesday";
        break;

        case 3:
        dayName="Wednesday";
        break;

        case 4:
        dayName="Thursday";
        break;

        case 5:
        dayName="Friday";
        break;

        case 6:
        dayName="Saturday";
        break;
        
        default:
        dayName:"Invalid number";
        break;


      }
      return dayName;
    }
}

