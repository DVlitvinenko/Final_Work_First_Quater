//Задача: Написать программу, которая из имеющегося
//массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При
//решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.
using static MetodsForProgramm.Metods;

namespace FinalWorkForQuater
{
    public class Programm
    {
        public static void Main()
        {
            string[] array = CreateArray(Input("Введите размер массива: "));
            Filling(array);
            Console.WriteLine(Printing(array));
            if (array.Length > 3)
            {
                array = NewArrayFillingOld(array);
                Console.WriteLine(Printing(array));
            }
            else Console.WriteLine("Заданный массив в пределах целевого размера.");
        }
    }
}