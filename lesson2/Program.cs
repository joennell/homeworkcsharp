namespace lesson2;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число элементов массива:");
        try
        {
            var number = ReadInt();
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть больше нуля");
            }

            if (number == 1)
            {
                throw new ArgumentException("Массив должен состоять из более чем одного элемента");
            }

            int[] ar = new int[number];
            Console.WriteLine("Введите элементы массива по одному:");
            for (var i = 0; i < ar.Length; i++)
            {
                ar[i] = ReadInt();
            }

            int max = ar[0];
            int max2 = Int32.MinValue;
            for (var i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max2 = max;
                    max = ar[i];
                }
                else if (ar[i] > max2 && ar[i] != max)
                {
                    max2 = ar[i];
                }
            }

            if (max2 == Int32.MinValue)
            {
                Console.WriteLine("Все числа в массиве одинаковые, второго наибольшего нет");
            }
            else
            {
                Console.WriteLine($"Второе наибольшее число {max2}");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int ReadInt()
    {
        var num = Console.ReadLine();
        if (Int32.TryParse(num, out var number))
        {
            return number;
        }
        throw new ArgumentException("Введите число");
    }
}