using System;
using Collection.Generic;

namespace newNmaespace
{
    class Program
    {
        static void Main(int[] args)
        {
            int[] array = {1,5,4,1,2,6,7,5,1,8};
            Sort(array);
        }
        
        static void Sort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                bool swaped = false;
                for(int a = 0; a < array.Length - i - 1; a++)
                {
                    if(array[a] > array[a + 1])
                    {
                        Swap(array, a, a + 1);
                        swaped = true;
                    }
                }
                if(!swaped)
                    break;
            }
        }
        
        static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

    }
}