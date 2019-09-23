using System;
using System.Collections.Generic;

class Riddles
{
    public string Riddle;
    public string Punchline;

    public Riddles(string riddle, string punchline)
    {
      Riddle = riddle;
      Punchline = punchline;
    }

    // public string RiddlePicker()
    // {
    //   string randomRiddle = (Math.random(RiddleList));
    //   return randomRiddle;
    // }

  public class Program
  {
    public static void Main()
    {
      Riddles teapot = new Riddles("What begins with T, ends with T, and has T in it?", "teapot");
      // teapot.Riddle = ;
      // teapot.Punchline = ;

      Riddles egg = new Riddles("What has to be broken before it can be used?", "egg");
      // egg.Riddle = ;
      // egg.Punchline = ;

      Riddles breath = new Riddles("You can hold it without using your hands or your arms. What is it?", "breath");
      // breath.Riddle = ;
      // breath.Punchline = ;

      // List<Riddles> RiddleList = new List<Riddles>() {teapot, egg, breath};
      object[] riddles = {teapot.Punchline, egg.Punchline, breath.Punchline};


      Console.WriteLine(riddles[1]);


    }
  }
}

git 
//
//     Console.WriteLine();
//     string egg = Console.ReadLine();
//
//     if (egg == "egg")
//     {
//       //draw randomly from array
//
//       Console.WriteLine("Jimmy’s mother had three children. The first was called April, the second was called May. What was the name of the third?");
//     }
//
//     else
//     {
//     Console.WriteLine("Sorry, wrong answer.");
//     }
//
//     string jimmy = Console.ReadLine();
//
//     if (jimmy == "jimmy")
//     {
//       Console.WriteLine();
//     }
//
//     else
//     {
//       Console.WriteLine("Sorry, wrong answer.");
//     }
//
//     string teapot = Console.ReadLine();
//
//     if(teapot == "teapot")
//     {
//       Console.WriteLine("GREAT JOB!!!!");
//     }
//
//     else
//     {
//       Console.WriteLine("You Lose!!!!");
//     }
//
//
//   }
// }
