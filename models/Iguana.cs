using System;

namespace classes.models
{
  public class Iguana
  {
    public int Price { get; private set; }
    public string HappyNoises { get; private set; }
    public string SadNoises { get; private set; }
    public string Name { get; set; }

    public void Feed()
    {
      Console.WriteLine("${HappyNoises}");
    }
    public void Euthanize()
    {
      Console.WriteLine("${SadNoises}");
    }
    public Iguana(int Price, string SadNoises, string Name)
    {
      Price = 200;
      SadNoises = "{Name}: ...";
      HappyNoises = "{Name}: ...";
      Name = "";
    }
  }
}