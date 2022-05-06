using System;

namespace Ref
{
    /*
     * 1. Написать метод Resize изменяющий количество элементов
массива (метод должен иметь возможность увеличить или
уменьшить количество элементов массива).

2. Написать методы для добавления элемента в начало массива, в
конец массива и по указанному индексу.

3. Написать методы для удаления первого элемента массива,
последнего элемента массива и элемента по указанному индексу.
    */
    class Program
    {
        static void Resize(ref int [] myArray, int namber)
        {
            myArray=new int[namber];
        }
        static void Main() 
        {
            int[] myArray = new int[5];

            Console.WriteLine("Введите число для изменения колличества элементов массива: ");

            int namber=5+int.Parse(Console.ReadLine());

            if (namber >= 0)

            {
                Resize(ref myArray, namber);

                Console.WriteLine("Колличество элементов массива: ");

                Console.WriteLine(myArray.Length);
            }
            else Console.WriteLine("Колличество элементов массива меньше ноля!");

            Console.ReadLine();
        }

    }
}
