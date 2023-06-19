namespace GenericPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Practice Problem !");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.DeleteMethod \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        int[] intArray = { 1, 2, 3, 4, 5 };
                        DeleteArray.DeleteMethod(ref intArray, 3);
                        Console.WriteLine(string.Join(", ", intArray));

                        double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
                        DeleteArray.DeleteMethod(ref doubleArray, 4.5);
                        Console.WriteLine(string.Join(", ", doubleArray));

                        char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
                        DeleteArray.DeleteMethod(ref charArray, 'b');
                        Console.WriteLine(string.Join(", ", charArray));
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}