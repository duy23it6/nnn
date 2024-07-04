using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // 
        // Ý 1: Tính tổng và trung bình của một danh sách số
        int[] numbers = { 5, 10, 15, 20, 25 };
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        double average = (double)total / numbers.Length;
        Console.WriteLine($"Tổng của danh sách số: {total}");
        Console.WriteLine($"Trung bình của danh sách số: {average}");

        // Ý 2: Tìm số lớn nhất và nhỏ nhất trong một danh sách số
        Console.WriteLine($"Số lớn nhất trong danh sách: {numbers.Max()}");
        Console.WriteLine($"Số nhỏ nhất trong danh sách: {numbers.Min()}");

        // Ý 3: Chuyển đổi nhiệt độ từ độ Celsius sang độ Fahrenheit
        double celsius = 25;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} độ Celsius = {fahrenheit} độ Fahrenheit");

        // Ý 4: Tìm số nguyên tố trong một khoảng số
        int start = 10;
        int end = 30;
        Console.WriteLine("Các số nguyên tố trong khoảng " + start + " đến " + end + " là:");
        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                Console.WriteLine(num);
            }
        }

        // Ý 5: Tính giai thừa của một số
        int number = 5;
        int result = Factorial(number);
        Console.WriteLine($"Giai thừa của {number} là: {result}");
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}