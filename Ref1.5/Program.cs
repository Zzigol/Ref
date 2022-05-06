using System;

namespace Ref
{
    /*
     * 1. Написать метод Resize изменяющий количество элементов
массива (метод должен иметь возможность увеличить или
уменьшить количество элементов массива).
    */
    class Program
    {
        static void Resize<T>(ref T[] myArray, int namber)
        {
            T[] myArrayNew = new T[namber];
            
                for (int i = 0; i < myArray.Length && i < myArrayNew.Length; i++)
                    myArrayNew[i] = myArray[i];
            myArray=myArrayNew;
        }
        static void Main()
        {

            //int[] myArray = new int[] { 1, 2, 3, 4 , 5, 5, 5 ,5 ,5 ,5 ,5 };
            string[] myArray = new string[] { "one", "two", "three" };

            Console.WriteLine("Введите число для изменения колличества элементов массива: ");

            int namber = int.Parse(Console.ReadLine());

            
                Resize(ref myArray, namber);

                Console.WriteLine("Колличество элементов массива: ");

                Console.WriteLine(myArray.Length);

               //foreach (int i in myArray) Console.WriteLine(i);
            
            Console.ReadLine();
        }

    }
}