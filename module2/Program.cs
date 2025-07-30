using  System;
class Program{
    static void Main(string[] args){
      //Type Conversion
      int num= Convert.ToInt32("56");
      Console.WriteLine(num);

      //Sum of two numbers
      Console.WriteLine("Enter first number");
      int num1= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter second number");
      int num2= Convert.ToInt32(Console.ReadLine());
      int sum= num1+num2;
      Console.WriteLine("Sum is "+sum);

      //For Handling decimal numbers
      //Use Convert.ToDouble 

      //Mad Lib 
      Console.WriteLine("Enter a color");
      string color= Console.ReadLine();
      Console.WriteLine("Enter a plural noun");
      string pluralNoun= Console.ReadLine();
      Console.WriteLine("Enter a celebrity name");
      string celebrity= Console.ReadLine();


      Console.WriteLine("Roses are "+ color);
      Console.WriteLine(pluralNoun + " are blue");
      Console.WriteLine("I love "+ celebrity);


      //Arrays
      int[] nums= {1, 5, 3, 55, 34, 65, 54};
      nums[0]=77;
      Console.WriteLine(nums[0]);

      string[] names= new string[5]; //Array of strings with size 5
      names[0]= "Jimmy";
      names[1]= "Robin";

      Console.WriteLine(names[1]);
    }
}
