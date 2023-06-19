using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    public class DeleteArray
    {
        public static void DeleteMethod<T>(ref T[] array, T elementToDelete)
        {
            int index = Array.IndexOf(array, elementToDelete);
            if (index >= 0)
            {
                T[] newArray = new T[array.Length - 1];
                Array.Copy(array, 0, newArray, 0, index);
                Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
                array = newArray;
            }
        }
    }
}
