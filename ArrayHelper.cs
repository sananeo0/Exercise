using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class ArrayHelper
    {
        public static string[] Add(string[] array,string newValue)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = newValue;
            return array;    
        }
        public static string[] Remove(string[] array, string newValue)
        {
            int remove = Array.IndexOf(array, newValue);
            if(remove >= 0)
            {
                for (int i = remove; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, array.Length - 1);
            }
            return array;
        }
    }
}
