using System;

namespace Ref
{
    /*
     
2. Написать методы для добавления элемента в начало массива, в
конец массива и по указанному индексу.

    */
    class Program
    {
        static void FirstNam<T>(ref T[] myArray, T namber)
        {
            AnyNam<T>(ref myArray, 0, namber);
        }

        static void LastNam<T>(ref T[] myArray, T namber)
        {
            AnyNam<T>(ref myArray, myArray.Length, namber);
        }

        static void AnyNam<T>(ref T[] myArray, int index, T namber)
        {
            T[] newArray = new T[myArray.Length + 1];
            newArray[index] = namber;
            for (int i = 0; i < myArray.Length; i++)
            { 
                if (i < index)
                  newArray[i] = myArray[i];
                if (i >= index)
                  newArray[i+1] = myArray[i];
            }
            myArray = newArray;
        }
        static void Main()
        {
            
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Введите первое число массива: ");

            int Firstnamber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число массива: ");

            int Lastnamber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите index массива: ");

            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число массива: ");

            int number = int.Parse(Console.ReadLine());


            FirstNam(ref myArray, Firstnamber);
            LastNam(ref myArray, Lastnamber);
            AnyNam(ref myArray, index, number);

            Console.WriteLine("Массив:");

            foreach (int i in myArray) Console.Write(" "+i);
           
            Console.ReadLine();
        }

    }
}
