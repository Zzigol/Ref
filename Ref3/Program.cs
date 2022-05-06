using System;

namespace Ref
{
    /*
3. Написать методы для удаления первого элемента массива,
последнего элемента массива и элемента по указанному индексу.
    */
    class Program
    {
        static void FirstNam<T>(ref T[] myArray)
        {
            AnyNam<T>(ref myArray, 0);
        }

        static void LastNam<T>(ref T[] myArray)
        {
            AnyNam<T>(ref myArray, myArray.Length-1);
        }

        static void AnyNam<T>(ref T[] myArray, int index)
        {
            T[] newArray = new T[myArray.Length - 1];
            //newArray[index] = namber;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i < index)
                    newArray[i] = myArray[i];
                if (i > index)
                    newArray[i - 1] = myArray[i];
            }
            myArray = newArray;
        }
        static void Main()
        {

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

           

            Console.WriteLine("Введите index массива: ");

            int index = int.Parse(Console.ReadLine());

            FirstNam(ref myArray);
            
            LastNam(ref myArray);
            AnyNam(ref myArray, index);

            Console.WriteLine("Массив:");

            foreach (int i in myArray) Console.Write(" " + i);

            Console.ReadLine();
        }

    }
}