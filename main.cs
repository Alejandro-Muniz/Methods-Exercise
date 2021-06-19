using System;
using System.Collections.Generic;
using System.Linq;
class MainClass
{
  //ARITHMETIC

  //1. Arithmetic Addition; intergers
  static int Addition(int num1, int num2)
  {
    return num1 + num2; 
  }

  //2. Arithmetic Subtraction; intergers
  static int Subtraction(int num1, int num2)
  {
    return num1 - num2;
  }

  //3. Arithmetic Multiplication; intergers
  static int Multiplication(int num1, int num2)
  {
    return num1 * num2; 
  }

  //4. Arithmetic Division; intergers return with no remainder
  static int Division(int num1, int num2)
  {
    return num1 / num2;
  }

  //5. Arithmetic Modualtion; intergers return with no remainder
  static int Modulation(int num1, int num2)
  {
    return num1 % num2;
  }

  //6. Arithmetic Exponentiation; intergers return with no remainder
  static int Exponentiation(int num1, int num2)
  {
    return num1 ^ num2;
  }
  
 //PRINTING THINGS TO THE CONSOLE
 
 //1. PrintStringArray 
 static void PrintStringArray(string[] names)
  {
    foreach(string name in names)
    {
      Console.WriteLine(name);
    }
  }
  //2. PrintStringList
  static void PrintStringList(List<string> names)
  {
    foreach(string name in names)
    {
      Console.WriteLine(name);
    }
  }  
  //3. PrintDicdt
  static void PrintDict(Dictionary<int, string> names)
  {
    foreach (KeyValuePair<int, string> os in names) //Console.WriteLine(os);
    {
      Console.WriteLine($"key: {os.Key} value: {os.Value}");
    }
  }

  // CREATING COLLECTIONS

  //1. FillStrArray
  static string[] FillStrArray(string strOne,string strTwo, string strThree, string strFour)
  {
    string[] stringArr = new string[4]
    {strOne, strTwo, strThree, strFour};
    foreach (string tattoo in stringArr) Console.WriteLine(tattoo);
    return stringArr;
  }
  
  //2. FillIntArray
  static int[] FillIntArray(int intOne,int intTwo, int intThree, int intFour)
  {
    int[] intArr = new int[4]
    {intOne, intTwo, intThree, intFour};
    foreach (int numbers in intArr) Console.WriteLine(numbers);
    return intArr;
  }
  
  //3. FillList
  static List<string> FillList(string[] characterArray)
  {
    List<string> charList = new List<string>();
    //foreach (string name in characterArray) charList.Add(name);  // copy array to string with loop
    charList = characterArray.ToList();
    foreach (string name in charList) Console.WriteLine(name);
    
    return charList;
  }

  //4. FillDict
  static Dictionary<int, string> FillDict(int[] intArr, string[] stringArr)
  {
    Dictionary<int, string> newDict = new Dictionary<int, string>();
    int dictLength = intArr.Length;
    for (int slot = 0; slot < dictLength; slot++) 
    {
      newDict.Add(intArr[slot], stringArr[slot]);
    }
    foreach(KeyValuePair<int,string> toon in newDict) 
    {
      Console.WriteLine($"key: {toon.Key} value: {toon.Value}");
    }
    return newDict;
  }

  //****************************************************************
  //****************************************************************

  public static void Main (string[] args) 
  {   
    //Printing Arithmetic using the methods above
    {
      Console.WriteLine("PRINTING ARITHMETIC USING METHODS\n");

      //1.Addition
      Console.WriteLine("1. Addition\n");
      Console.WriteLine (Addition(2,5));
      Console.WriteLine("\n");

      //2.Subtraction
      Console.WriteLine("2. Subtraction\n");
      Console.WriteLine (Subtraction(5,3));
      Console.WriteLine("\n");

      //3. Multiplication
      Console.WriteLine("3. Subtraction\n");
      Console.WriteLine (Multiplication(10,10));
      Console.WriteLine("\n");

      //4. Division
      Console.WriteLine("4. Division\n");
      Console.WriteLine (Division(100,20));
      Console.WriteLine("\n");

      //5. Modulation
      Console.WriteLine("5. Modulation\n");
      Console.WriteLine (Modulation(50,10));
      Console.WriteLine("\n");

      //6.Exponentiation
      Console.WriteLine("6. Exponentiation\n");
      Console.WriteLine (Exponentiation(35,5));
      Console.WriteLine("\n");    
    }


    //PRINTING THINGS TO THE CONSOLE
    
    Console.WriteLine("PRINTING THINGS TO THE CONSOLE\n");
    
    //1. PrintStringArray
    {
      Console.WriteLine("1. PrintStringArray\n");
      string[] people = { "Johnny", "Sue", "Tyrone"};
      PrintStringArray(people);
      Console.WriteLine("\n");
    }

    //2. PrintStringList
    {
      Console.WriteLine("2. PrintStringList\n");
      List<string> ListOfCharacters = new List<string>{"The Tic", "Birdman", "Batman"};
      PrintStringList(ListOfCharacters);
      Console.WriteLine("\n");
    }

    //3. PrintDict   
    {
      Console.WriteLine("3. PrintDict\n");
      Dictionary<int, string> operatingSystems = new Dictionary<int, string>
      {
          {1, "Mac"},
          {2, "Windows"},
          {3, "Linux"}
      };
      Console.WriteLine("\n");
      PrintDict(operatingSystems);
      Console.WriteLine("\n");
      Console.WriteLine("\n");
    }
    
    //CREATING COLLECTIONS

    Console.WriteLine("CREATING COLLECTIONS\n");

    //1. FillStrArray
    {
      Console.WriteLine("1. FillStrArray\n");
      string strOne = "Dude What's Mine Say?!";
      string strTwo = "Sweet!!!";
      string strThree = "What's Mine Say?";
      string strFour = "Dude!!!";
    
      string[] newStrArr = FillStrArray(strOne, strTwo, strThree, strFour);
      Console.WriteLine(newStrArr);
      Console.WriteLine("\n");
    }

    //2. FillStrArray
    {
      Console.WriteLine("2. FillStrArray\n");
      
      int num1 = 1;
      int num2 = 2;
      int num3 = 3;
      int num4 = 4;

      int[] newIntArr = FillIntArray(num1, num2, num3, num4);
      Console.WriteLine(newIntArr);
      Console.WriteLine("\n");
    }

    // 3. FillList
    {
      Console.WriteLine ("3. FillList\n");
      string[] characterArray = new string[3]{"Birdman", "Batman", "Ed"};
      Console.WriteLine(FillList(characterArray));
      Console.WriteLine("\n");
    }

    //4. FillDict
    {
      Console.WriteLine("4. FillDict\n");
      String[] stringArr  = {"Bridman", "Batman", "Ed" };
      int[] intArr = {1, 2, 3};
      Dictionary<int, string> newDict = new Dictionary <int, string>();
      newDict = FillDict(intArr, stringArr);
      Console.WriteLine(newDict);
      Console.WriteLine("\n");
    }  
  }

} 