namespace MetodsForProgramm
{
    public class Metods
    {
        public static string[] CreateArray(int size)
        {
            return new string[size];
        }

        public static int Input (string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Filling(string[]array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемент массива номер {i+1}: ");
                array[i] = $"{Console.ReadLine()}";
            }
        }

        public static string Printing(string[] array)
        {
            int size = array.Length;
            string result = String.Empty;
            for(int i = 0;i < size;i++)
            {
                result += $"{array[i]} ";
            }
            return result;
        }

        public static string[] NewArrayFillingOld(string []array, int min = 0, int max = 4)
        {
            string[] resultArray = CreateArray(new Random().Next(min, max)); 
            int size = resultArray.Length;
            for(int i = 0; i<size;i++)
            {
                resultArray[i] = array[i];
            
            }
            return resultArray;
        }
    }
}