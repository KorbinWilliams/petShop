using System;
using classes.models;

namespace petShop
{
  class Program
  {
    static void Main(string[] args)
    {
      MyStore Inventory = new MyStore();
      Console.WriteLine("Welcome to your pet shop, what would you like to do?");
      Console.WriteLine("(b)uy an animal");
      Console.WriteLine("(f)eed an animal");
      Console.WriteLine("(e)uthanise Animal");
      ConsoleKeyInfo choice = Console.ReadKey();
      if (choice.Key == ConsoleKey.B)
      {
        Console.Clear();
        Console.WriteLine("Buy an (i)guana, a (b)ird, or a (v)elociraptor?")
          ConsoleKeyInfo choice2 = Console.ReadKey();
        if (choice2.Key == ConsoleKey.I)
        {
          Inventory.AddInventory(iguana)
          }
      }
    }
  }
}
