using System;

namespace classes.models
{
  public class Velociraptor
  {
    public string Name { get; set; }
    public int Price { get; private set; }
    public string SadNoises { get; private set; }
    public string HappyNoises { get; private set; }
    public void Feed()
    {
      Console.WriteLine("${HappyNoises}");
    }
    public void Euthanize()
    {
      Console.WriteLine("${SadNoises}");
    }
    public Velociraptor(string SadNoises, string HappyNoises, int Price, string Name)
    {
      Price = 3000;
      SadNoises = "Skreeeee";
      HappyNoises = "Skreeeee";
      Name = "";
    }
  }
}