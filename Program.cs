namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "b", "c" };

            string[] newArray1 = ArrayHelper.Add(arr, "d");
            foreach (string item in newArray1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            string[] newArray2 = ArrayHelper.Remove(newArray1, "c");
            foreach (string item in newArray2)
            {
                Console.WriteLine(item);
            }
        }

    }
}