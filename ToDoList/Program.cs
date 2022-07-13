using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main ()
    {
      List<Item> newList = new List<Item>();

      Console.WriteLine("To Do List Main Menu!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string response = Console.ReadLine();
      if (response == "Add" || response == "add")
      {
        AddItem();
      }
      else if (response == "View" || response == "view")
      {
        ViewList();        
      }
        // Console.WriteLine("Please enter the description for the new item.");
        // string description = Console.ReadLine();
        // Item newItem = new Item(description);
        // Console.WriteLine(description + " has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");
    }
  
    static void AddItem()
    {
    Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        // Console.WriteLine(description + " has been added to your list.");
        // Console.WriteLine("Would you like to add another Item? ('Y' for yes, 'N' for no)");
        Console.WriteLine(description + " has been added to your list." );
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Would you like to add an item to your list or view your list? ['Add' for add, 'View' for view]");
        string continueOn = Console.ReadLine();
        // if (continueOn == "Y" || continueOn == "y")
        if (continueOn == "Add" || continueOn == "add")
        {
          AddItem();
        }
        else if (continueOn == "View" || continueOn == "view")
        {
          ViewList();
        }
    }

    static void ViewList()
    {
      Console.WriteLine("Here is your list.");
      Console.WriteLine("----------------------------");
      List<Item> result = Item.GetAll();

      if (result.Count == 0)
      {
        Console.WriteLine("You don't have any item in the list yet");
        Main();
      }
      else
      {
        foreach (Item thisItem in result)
        {
          Console.WriteLine(thisItem.Description);
        }
        Main();
      }
    }
  }
}