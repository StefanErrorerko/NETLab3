using System;
using System.Threading;
using NETLab3.GameParticipants;

namespace NETLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(@"===Розпорядник гри===
    Налаштуйте, будь ласка, гру
    Кiльiкiсть полiв на дошцi:"
                );
                var boardsize = TryRead();
                Console.WriteLine("Чудово! Вкажiть тепер кiлькiсть фiшок вагою 10:");
                int[] chip = new int[3];
                chip[0] = TryRead();
                Console.WriteLine("Тепер кiлькiсть фiшок вагою 50:");
                chip[1] = TryRead();
                Console.WriteLine("Тепер кiлькiсть фiшок вагою 100:");
                chip[2] = TryRead();

                var croupier1 = Croupier.GetInstance(boardsize, chip[0], chip[1], chip[2]);

                Console.WriteLine($"Круп'є готовий роздати дошку з {croupier1.Board.Size}, фiшки:");
                foreach(var item in croupier1.Chips)
                {
                    Console.Write(item + " ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static int TryRead()
        {
            bool flag = false;
            int amount = -1;
            while (!flag)
            {
                string? value = Console.ReadLine();
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ви нiчого не ввели.");
                }
                else
                {
                    try
                    {
                        amount = Int32.Parse(value);
                        flag = true;
                    }
                    catch
                    {
                        Console.WriteLine("Необхiдно ввести цiле число");
                    }
                }
            }
            return amount;
        }
    }
}
