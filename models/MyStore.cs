using System;
using System.Collections.Generic;

namespace classes.models
{
  public class MyStore
  {
    public List<Bird> Birds { get; private set; } = new List<Bird>();
    public List<Iguana> Iguanas { get; private set; } = new List<Iguana>();
    public List<Velociraptor> Velociraptors { get; set; } = new List<Velociraptor>();

    public void AddInventory(Velociraptor velociraptor)
    {
      Console.Write("What would you like to name it?");
      velociraptor.Name = Console.ReadLine();
      Velociraptors.Add(velociraptor);
    }
    public void AddInventory(Bird bird)
    {
      Console.Write("What would you like to name it?");
      bird.Name = Console.ReadLine();
      Birds.Add(bird);
    }
    public void AddInventory(Iguana iguana)
    {
      Console.Write("What would you like to name it?");
      iguana.Name = Console.ReadLine();
      Iguanas.Add(iguana);
    }
    public void ReadInventory()
    {
      Console.WriteLine(Birds.ToString(), Iguanas.ToString(), Velociraptors.ToString());
    }
    public MyStore()
    { }
  }
}