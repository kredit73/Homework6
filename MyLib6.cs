public class MyLib6
{
    // Создание массива
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }

    // Заполнение пользовательскими числами 
    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1} число и нажмите Enter: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }


    //Метод подсчета положительных чисел в массиве

    public static int SumOfPosirtive(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]>0) count++;
        }
        return count;

    }

    //Вывод массива
    public static string Print(int[] array)
    {

        string result = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i]}, ";
        }
        return result;
    }
















}