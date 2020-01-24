using System;

namespace classes.models
{
  public class Bird
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
      Console.WriteLine("${HappyNoises}");
    }
    public Bird(int Price, string SadNoises, string Name)
    {
      Price = 100;
      HappyNoises = "{Name}: Squak.";
      SadNoises = "${Name}: Polly wanna live.";
      Name = "";
    }
  }
}