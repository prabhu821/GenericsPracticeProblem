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
                Console.WriteLine("\nSelect the operation to perform \n1.DeleteMethod \n2.Generic class DeleteMethod \n3.Exit");
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
                    case 2:
                        int[] intArray1 = { 1, 2, 3, 4, 5 };
                        DeleteArray<int> intDeleteArray = new DeleteArray<int>();
                        intDeleteArray.DeleteMethod(ref intArray1, 3);
                        Console.WriteLine(string.Join(", ", intArray1)); 

                        double[] doubleArray1 = { 1.5, 2.5, 3.5, 4.5, 5.5 };
                        DeleteArray<double> doubleDeleteArray = new DeleteArray<double>();
                        doubleDeleteArray.DeleteMethod(ref doubleArray1, 4.5);
                        Console.WriteLine(string.Join(", ", doubleArray1)); 

                        char[] charArray1 = { 'a', 'b', 'c', 'd', 'e' };
                        DeleteArray<char> charDeleteArray = new DeleteArray<char>();
                        charDeleteArray.DeleteMethod(ref charArray1, 'b');
                        Console.WriteLine(string.Join(", ", charArray1));
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}