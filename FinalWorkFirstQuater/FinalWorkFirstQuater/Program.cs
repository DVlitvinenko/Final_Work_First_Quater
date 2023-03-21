
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
            Console.Write(" Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}