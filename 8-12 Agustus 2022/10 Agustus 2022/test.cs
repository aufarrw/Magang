public static class Extensions
{
    public static bool find<T>(this T[] array, T target) {
        return Array.IndexOf(array, target) != -1;
    }
}
 
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 4;
 
        bool isExist = array.find(target);
        if (isExist) {
            Console.WriteLine("Element found in the array");
        }
        else {
            Console.WriteLine("Element not found in the given array");
        }
    }
}

/*string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
var stringToFind = "Bill";
 
var result = Array.Find(names, element => element == stringToFind); // returns "Bill"*/