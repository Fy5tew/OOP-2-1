using System;

public interface IInformation {
    bool Inform();
}


public abstract class Information {
    public abstract bool Inform();
}


public abstract partial class Product : Information, IInformation {
    private decimal _price;
    private decimal _weight;
    private string _manufacturer;
    public string Manufacturer {
        get => _manufacturer;
        set {
            if (value == null) {
                throw new ProductException("Manufacturer cannot be null");
            }
            _manufacturer = value;
        }
    }
    public decimal Price {
        get => _price;
        set {
            if (value <= 0) {
                throw new ProductPriceException("Product price cannot be <= 0", value);
            }
            _price = value;
        }
    }
    public decimal Weight {
        get => _weight;
        set {
            if (value <= 0) {
                throw new ProductWeightException("Product weight cannot be <= 0", value);
            }
            _weight = value;
        }
    }

    public override bool Inform() {
        Console.WriteLine("Вызван метод Inform() из абстрактного класса Information.");
        return true;
    }

    bool IInformation.Inform() {
        Console.WriteLine("Вызван метод Inform() из интерфейса IInformation.");
        return false;
    }
}


public class Furniture : Product {
    public override string ToString() {
        return "Это мебель.";
    }
}


public sealed class Sofa : Furniture {
    public override string ToString() {
        return "Это диван.";
    }
}


public class Bed : Furniture {
    public override string ToString() {
        return "Это кровать.";
    }
}


public class Wardrobe : Furniture {
    public override string ToString() {
        return "Это шкаф.";
    }
}


public class SlidingWardrobe : Wardrobe {
    public override string ToString() {
        return "Это шкаф-купе.";
    }
}


public class Hanger : Furniture {
    public override string ToString() {
        return "Это вешалка.";
    }
}


public class BedsideTable : Furniture {
    public override string ToString() {
        return "Это тумба.";
    }
}


public class Chair : Furniture {
    public override string ToString() {
        return "Это стул.";
    }
}


public class Printer {
    public void IAmPrinting(Product someobj) {
        Console.WriteLine(someobj.ToString());
    }
}
