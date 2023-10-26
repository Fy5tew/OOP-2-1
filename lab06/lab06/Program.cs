using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main started");
        try {
            Sofa sofa = new Sofa();
            Bed bed = new Bed();
            Wardrobe wardrobe = new Wardrobe();

            sofa.Weight = 15;
            bed.Price = 235;
            wardrobe.Price = 205;
            wardrobe.Weight = 79;

            try {
                sofa.Price = -178;
            }
            catch (ProductPriceException ex) {
                Console.WriteLine($"{ex.GetType().Name}: '{ex.Message}' ({ex.InvalidPrice})");
                sofa.Price = 178;
            }

            try {
                bed.Weight = 0;
            }
            catch (ProductWeightException ex) {
                Console.WriteLine($"{ex.GetType().Name}: '{ex.Message}' ({ex.InvalidWeight})");
                bed.Weight = 47;
            }

            try {
                wardrobe.Manufacturer = null;
            }
            catch (ProductException ex) {
                Console.WriteLine($"{ex.GetType().Name}: '{ex.Message}'");
            }

            try {
                Debug.Assert(wardrobe.Manufacturer != null, "Wardrobe manufacturer is null!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

            Warehouse warehouse = new Warehouse();
            warehouse.AddProduct(sofa);
            warehouse.AddProduct(bed);
            warehouse.AddProduct(wardrobe);

            try {
                Console.WriteLine("[START] Try to get 'warehouse[4]'");
                Console.WriteLine(warehouse[4]);
            }
            catch (IndexOutOfRangeException ex) {
                Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
            catch (Exception ex){
                Console.WriteLine("Some unexpexted exception");
                throw ex;
            }
            finally {
                Console.WriteLine("[END] Try to get 'warehouse[4]'");
            }
        }
        catch (Exception ex) {
            Console.WriteLine("Unexpected Exception");
            Console.WriteLine(ex);
        }
        finally {
            Console.WriteLine("Finally, top try ended");
        }
        Console.WriteLine("Main ended");
    }
}