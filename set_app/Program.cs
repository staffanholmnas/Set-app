using System;
using System.Collections.Generic;
using System.Linq;

namespace set_app
{
  class Program
  {
    static void Main(string[] args)
    {

      // Declare and assign values to variables
      string[] letters = new string[] { "A", "B", "C", "D", "E" };
      int maxSetLength = 10;
      int setNumber = 0;
      string element;
      int index = 0;
      int size = 0;
      string selection = "";
      int setAmount = 0;
      int[] sets = new int[] { -1, -1 };

      // 1. Decide the number of sets
      // 2. Select number of elements in the first set
      // 3. Input elements
      // 4. Repeat for every set
      // 5. You are presented with a list of operations

      Console.WriteLine("Welcome to the set app!");
      do
      {
        // Select the number of sets
        Console.WriteLine("Please choose the number of sets you want to create (2-5): ");
        try
        {
          setAmount = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Only numbers are accepted!");
        }
      }
      while (setAmount < 2 || setAmount > 5);

      List<string>[] a = new List<string>[setAmount]; // Create an array of sets
      for (int k = 0; k < setAmount; k++)
      {
        a[k] = new List<string>();
      }

      //------------------------------------------------------
      while (setNumber < setAmount)
      {
        // Create sets
        do
        {
          // Choose set length
          Console.Write("Enter the number of elements for set " + letters[setNumber] + " (Max size is " + maxSetLength + "). ");
          try
          {
            size = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.WriteLine("Only numbers are accepted!");
          }
        }
        while (size < 1 || size > maxSetLength);

        while (index < size)
        {
          // Input elements to a set
          Console.WriteLine("Enter the element at position " + index + ": ");
          element = Console.ReadLine();
          a[setNumber].Add(element);
          index++;
        }
        index = 0;
        Console.Write("This is your set " + letters[setNumber] + ": ");

        // Remove duplicates from the sets
        for (int i = 0; i < setAmount; i++)
        {
          a[i] = a[i].Distinct().ToList();
        }

        // Print the sets
        Print(a[setNumber]);
        if (setNumber == 0)
        {
          Console.WriteLine("(All duplicates are removed from the sets.)");
        }
        setNumber++;
        size = 0;
      }

      //-----------------------------------------------------------
      while (selection != "q")
      {
        // Choose set operations
        Console.WriteLine("");
        Console.WriteLine("Choose set operation:");
        Console.WriteLine("1. Union");
        Console.WriteLine("2. Intersection");
        Console.WriteLine("3. Difference");
        Console.WriteLine("4. Cartesian product");
        Console.WriteLine("5. Print the sets");
        Console.WriteLine("6. Count the sets");
        Console.WriteLine("Press q to quit.");
        selection = Console.ReadLine();

        // Call the different set functions with two sets as arguments
        if (selection == "1")
        {
          if (setAmount == 2)
          {
            // If there are only two sets. Order doesn't matter.
            Union(a[0], a[1]);
          }
          else
          {
            sets = SelectSets(sets, setAmount, letters, a);
            Union(a[sets[0]], a[sets[1]]);
          }

        }


        if (selection == "2")
        {
          if (setAmount == 2)
          {
            Intersection(a[0], a[1]); // Order doesn't matter
          }
          else
          {
            sets = SelectSets(sets, setAmount, letters, a);
            Intersection(a[sets[0]], a[sets[1]]);
          }
        }

        if (selection == "3")
        {
          sets = SelectSets(sets, setAmount, letters, a);
          Difference(a[sets[0]], a[sets[1]]);
        }


        if (selection == "4")
        {
          sets = SelectSets(sets, setAmount, letters, a);
          CartesianProduct(a[sets[0]], a[sets[1]]);
        }


        if (selection == "5")
        {
          // Print out the chosen sets
          for (int m = 0; m < a.Length; m++)
          {
            Console.Write("Set " + letters[m] + ": ");
            Print(a[m]);
          }
        }


        if (selection == "6")
        {
          List<string> setSum = new List<string>();
          for (int n = 0; n < setAmount; n++)
          {
            // Count the elements in each set, duplicates have been removed
            Console.Write("The number of elements in set {0} is: ", letters[n]);
            Console.WriteLine(a[n].Count);
            // Copy all elements from every set to setSum
            foreach (string item in a[n])
            {
              setSum.Add(item);
            }
          }
          // All duplicates from the total are removed, the union of all sets
          setSum = setSum.Distinct().ToList();
          Console.WriteLine("The total amount of elements: {0} (Union of all sets)", setSum.Count);
        }
      }
    }

    public static void CartesianProduct(List<string> a1, List<string> a2)
    {
      Console.WriteLine("Set A:");
      Print(a1);
      Console.WriteLine("Set B:");
      Print(a2);
      Console.WriteLine("The cartesian product of A and B:");
      // Use nested for-loops to print the product of all elements
      for (int i = 0; i <= a1.Count - 1; i++)
      {
        if (i == 0)
        {
          Console.Write("{ ");
        }
        for (int j = 0; j <= a2.Count - 1; j++)
        {
          Console.Write("(" + a1[i] + " , " + a2[j] + ")");
          if (i != a1.Count - 1 || j != a2.Count - 1)
          {
            Console.Write(" , ");
          }
        }
        if (i == a1.Count - 1)
        {
          Console.WriteLine(" }");
        }
      }
    }

    public static void Difference(List<string> a1, List<string> a2)
    {
      // The elements in set 1 minus the ones in set 2.
      List<string> difference = a1.Except(a2).ToList();

      // Call the Print function
      Console.WriteLine("Set A:");
      Print(a1);
      Console.WriteLine("Set B:");
      Print(a2);
      Console.WriteLine("The difference of A and B:");
      Print(difference);
    }

    public static void Intersection(List<string> a1, List<string> a2)
    {
      // Use the intersect method from the linq framework and copy the values to a list.
      List<string> intersection = a1.Intersect(a2).ToList();

      // Call the Print function
      Console.WriteLine("Set A:");
      Print(a1);
      Console.WriteLine("Set B:");
      Print(a2);
      Console.WriteLine("The intersection of A and B:");
      Print(intersection);
    }

    public static void Union(List<string> a1, List<string> a2)
    {
      // Copy the elements from a2 and a1 to a3
      List<string> a3 = new List<string>();
      a3.AddRange(a1);
      a3.AddRange(a2);

      // Use the Distinct() method from linq to get unique values from the list that contains elements from both lists.
      // Since the method returns a type IEnumerable, the elements are copied to a list with the ToList() method.
      List<string> union = a3.Distinct().ToList();

      // Call the Print function
      Console.WriteLine("Set A:");
      Print(a1);
      Console.WriteLine("Set B:");
      Print(a2);
      Console.WriteLine("The union of A and B:");
      Print(union);
    }

    public static void Print(List<string> set)
    {
      Console.Write("{ ");
      for (int i = 0; i <= set.Count - 1; i++)
      {
        // Print the elements of a set separated by commas
        Console.Write(set[i]);
        if (i < set.Count - 1)
        {
          Console.Write(" , ");
        }
      }
      Console.WriteLine(" }");
    }

    public static int[] SelectSets(int[] sets, int setAmount, string[] letters, List<string>[] a)
    {
      // Select the two sets that you want to evaluate
      sets[0] = -1;
      sets[1] = -1;
      for (int j = 0; j < 2; j++)
      {
        do
        {
          // Print the options
          Console.WriteLine("Select the {0} set: ", j == 0 ? "first" : "second");
          for (int i = 0; i < setAmount; i++)
          {
            Console.Write((i + 1) + ". " + letters[i] + ": ");
            Print(a[i]);
          }
          try
          {
            // Only numbers will work
            sets[j] = Convert.ToInt32(Console.ReadLine()) - 1;
          }
          catch
          {
            Console.WriteLine("Only numbers are accepted!");
          }
          // The numbers must be between a certain interval
        } while (sets[j] < 0 || sets[j] > (setAmount - 1));
      }
      return sets;
    }
  }
}
