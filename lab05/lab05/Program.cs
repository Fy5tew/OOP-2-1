﻿using System;


public interface IInformation
{
    bool Inform();
}


public abstract class Information
{
    public abstract bool Inform();
}


public abstract partial class Product : Information, IInformation
{
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public decimal Weight { get; set; }

    public override bool Inform()
    {
        Console.WriteLine("Вызван метод Inform() из абстрактного класса Information.");
        return true;
    }

    bool IInformation.Inform()
    {
        Console.WriteLine("Вызван метод Inform() из интерфейса IInformation.");
        return false;
    }
}


public class Furniture : Product
{
    public override string ToString()
    {
        return "Это мебель.";
    }
}


public sealed class Sofa : Furniture
{
    public override string ToString()
    {
        return "Это диван.";
    }
}


public class Bed : Furniture
{
    public override string ToString()
    {
        return "Это кровать.";
    }
}


public class Wardrobe : Furniture
{
    public override string ToString()
    {
        return "Это шкаф.";
    }
}


public class SlidingWardrobe : Wardrobe
{
    public override string ToString()
    {
        return "Это шкаф-купе.";
    }
}


public class Hanger : Furniture
{
    public override string ToString()
    {
        return "Это вешалка.";
    }
}


public class BedsideTable : Furniture
{
    public override string ToString()
    {
        return "Это тумба.";
    }
}


public class Chair : Furniture
{
    public override string ToString()
    {
        return "Это стул.";
    }
}


public class Printer
{
    public void IAmPrinting(Product someobj)
    {
        Console.WriteLine(someobj.ToString());
    }
}


class Program
{
    static void Main(string[] args)
    {
        Sofa sofa = new Sofa();
        Bed bed = new Bed();
        Wardrobe wardrobe = new Wardrobe();

        Product[] products = new Product[] { sofa, bed, wardrobe };

        Printer printer = new Printer();

        printer.IAmPrinting(sofa);
        printer.IAmPrinting(bed);
        printer.IAmPrinting(wardrobe);

        Product product = new Sofa();

        if (sofa is IInformation)
        {
            Console.WriteLine("Объект sofa поддерживает интерфейс IInformation.");
            IInformation cloneableSofa = sofa;
            cloneableSofa.Inform();
        }

        if (sofa is Information)
        {
            Console.WriteLine("Объект sofa является экземпляром абстрактного класса Information.");
            Information baseSofa = sofa;
            baseSofa.Inform();
        }

        new Lab5().Test();
    }
}