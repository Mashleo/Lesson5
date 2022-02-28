using System;

namespace FirstLibrary
{
    public class ArrayWorker
    {
        public int[] firstMetod(int[] array)
        {
            var lenght = array.Length;
            var k = lenght / 2; 

            for (int i = 0; i < k; i++)
            {
                var temp = array[i];
                array[i] = array[lenght - 1 - i]; 
                array[lenght - 1 - i] = temp;
            }
            return array;
        }
        public int[] source;
        public int index;
        public int newValue;

   
       
        public int[] SecondMetod(int[] source1, int index1, int newValue1)
        {
            int[] newSource = new int[source1.Length+1];
            for (int i = 0; i < newSource.Length; i++)
            {
                if (i< index1)
                {
                    newSource[i] = source1[i];
                }
                else if (i==index1)
                {
                    newSource[i] = newValue1;
                }
                else 
                    newSource[i] = source1[i-1];
                
                
            }

            
            return newSource;
        }
    }
}
