using System;

namespace homework006
{
    class Program
    {
        static void Main(string[] args)
        {
            int grandmasAmount;
            int onePersonWaitingTime = 10;
            int fullTime;
            int hour;
            int min;
            Console.Write("Введите количество бабушек: ");
            grandmasAmount =Convert.ToInt32 (Console.ReadLine());
            fullTime = grandmasAmount * onePersonWaitingTime;
            hour = fullTime / 60;
            min = fullTime % 60;
            Console.WriteLine("Вы должны отстоять в очереди " + hour + " часа " + min + "минут.");
        }
    }
}
