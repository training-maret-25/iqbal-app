using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Serilog;
using System.Security.Cryptography.X509Certificates;

class OopLsp {
public abstract class Bird
{
    public abstract void MakeSound();
}

public interface IFlyingBird
{
    void Fly();
}

public class Sparrow : Bird, IFlyingBird
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp chirp!");
    }

    public void Fly()
    {
        Console.WriteLine("Sparrow is flying!");
    }
}

public class Penguin : Bird
{
    public override void MakeSound()
    {
        Console.WriteLine("Honk honk!");
    }
}

class Program
{
    static void Main()
    {
        Sparrow sparrow = new Sparrow();
        sparrow.MakeSound();
        sparrow.Fly(); 

        Penguin penguin = new Penguin();
        penguin.MakeSound(); 
}

}
}