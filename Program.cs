using static ASSLINQ.ListGenerator;

namespace CS_LINQ_A01;
internal class Program
{
    static void Main()
    {
        #region LINQ - Restriction Operators
        /// 1. Find all products that are out of stock.
        ProductList.Where(p => p.UnitsInStock == 0).Print();

        /// 2. Find all products that are in stock and cost more than 3.00 per unit.
        ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).Print();

        /// 3. name is shorter than their value.
        string[] Arr1 = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        Arr1.Where((s, i) => s.Length < i).Print();

        #endregion

        #region LINQ - Element Operators
        /// 1. first Product out of Stock.
        var firstOutOfStock = ProductList.Where(p => p.UnitsInStock == 0).First();
        Console.WriteLine(firstOutOfStock);

        /// 2. the first product whose Price > 1000.
        // throws InvalidOperationException if no element is found
        var first = ProductList.Where(p => p.UnitPrice > 1000).First();
        Console.WriteLine(first);

        /// 3. second number greater than 5 
        int[] Arr2 = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        var secondNumber = Arr2.Where(n => n > 5).Skip(1).First();
        Console.WriteLine(secondNumber);

        #endregion

        Console.ReadKey();
    }
}

static class HelperMethods // helper methods for printing collections
{
    public static void Print<T>(this IEnumerable<T> enumerable) => Console.WriteLine(string.Join("\n", enumerable));
}