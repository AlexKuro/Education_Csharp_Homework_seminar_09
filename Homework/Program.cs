namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        void Task64()
        {
            /*  Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
            который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
                 M = 1; N = 9. -> "3, 6, 9"
                 M = 13; N = 20. -> "15, 18" */
            Console.WriteLine("---- Задача 64 ----");
            Random rand = new Random();
            int numbersM = rand.Next(0, 50);
            int numbersN = rand.Next(50, 99);
            Console.WriteLine($"Введены значения {numbersM} и {numbersN} ");
            Console.WriteLine($"Все натуральные числа кратные 3-ём от {numbersM} до {numbersN}:");
            NaturalNumbers(numbersM, numbersN);
        }

        void Task65()
        {
            /*  Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который 
            найдёт сумму натуральных элементов в промежутке от M до N.
                M = 1; N = 15 -> 120
                M = 4; N = 8. -> 30 */
            Console.WriteLine("---- Задача 65 ----");
            /*Random rand = new Random();
            int numbersM = rand.Next(0, 9);
            int numbersN = rand.Next(9, 20); */
            Console.Write("Введите значение M: ");
            int numbersM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение N: ");
            int numbersN = Convert.ToInt32(Console.ReadLine());
            if (numbersM > numbersN)
            {
                int min = numbersM;
                numbersM = numbersN;
                numbersN = min;
            }

            Console.WriteLine($"Введены значения {numbersM} и {numbersN} ");
            Console.Write($"Сумма натуральных элементов в промежутке от {numbersM} до {numbersN} -> ");
            Console.Write(SumDigit(numbersM, numbersN));
        }

        void Task68()
        {
            /*  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
                    m = 2, n = 3 -> A(m,n) = 9    
                    m = 3, n = 2 -> A(m,n) = 29*/

            Console.WriteLine("---- Задача 68 ----");
            Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии.");
            /*Random rand = new Random();
            int m = rand.Next(0, 3);
            int n = rand.Next(0, 3); */
            Console.Write("Введите значение функции m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение фунцции n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Функция А({m}, {n}) = {A(m, n)}");
        }
        void NaturalNumbers(int numberM, int numberN)
        {
            if (numberM > numberN) return;
            numberM++;
            if (numberM % 3 == 0) Console.Write($"{numberM} ");
            NaturalNumbers(numberM, numberN);
        }

        int SumDigit(int numberM, int numberN, int sum = 0)
        {
            if (numberM > numberN) return sum;
            return sum += numberM + SumDigit(numberM + 1, numberN);
        }

        int A(int m, int n)
        {
            if (m == 0) return n = n + 1;
            else if (m > 0 && n == 0) return A(m - 1, n = 1);
            else if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
            else return 0;
        }

        Task64();
        Task65();
        Task68();

    }
}
