using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GAM109_Lab8
{
    public static class Bai1
    {
        // Declare shared resources and locks
        private static List<int> sharedList = new List<int>();
        private static readonly object listLock = new object();

        public static void bai1()
        {
            Console.WriteLine("\n=== BÀI 1: PRODUCER/CONSUMER THREADS ===");
            Console.WriteLine("Bắt đầu...\n");

            // Tạo và khởi động Thread1 (Producer)
            Thread thread1 = new Thread(ProducerThread);
            thread1.Name = "Producer";

            // Tạo và khởi động Thread2 (Consumer)
            Thread thread2 = new Thread(ConsumerThread);
            thread2.Name = "Consumer";

            // Khởi động các threads
            thread1.Start();
            thread2.Start();

            // Chờ cả 2 threads hoàn thành
            thread1.Join();
            thread2.Join();
        }

        static void ProducerThread()
        {
            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                // Sinh số ngẫu nhiên từ 1 đến 10
                int randomNumber = random.Next(1, 11);

                // Thread-safe thêm vào list
                lock (listLock)
                {
                    sharedList.Add(randomNumber);
                }

                Console.WriteLine($"[Producer - Lần {i}] Sinh số: {randomNumber}");

                // Nghỉ 2 giây
                Thread.Sleep(2000);
            }

            Console.WriteLine("[Producer] Hoàn thành 100 lần sinh số!");
        }

        static void ConsumerThread()
        {
            for (int i = 1; i <= 100; i++)
            {
                int number = 0;
                bool hasData = false;

                // Thread-safe lấy số từ list
                lock (listLock)
                {
                    if (sharedList.Count > 0)
                    {
                        // Lấy số đầu tiên và xóa khỏi list (FIFO)
                        number = sharedList[0];
                        sharedList.RemoveAt(0);
                        hasData = true;
                    }
                }

                if (hasData)
                {
                    // Tính bình phương
                    int square = number * number;
                    Console.WriteLine($"[Consumer - Lần {i}] Số: {number}, Bình phương: {square}");
                }
                else
                {
                    Console.WriteLine($"[Consumer - Lần {i}] Chưa có dữ liệu, chờ...");
                    i--; // Lặp lại lần này
                }

                // Nghỉ 1 giây
                Thread.Sleep(1000);
            }

            Console.WriteLine("[Consumer] Hoàn thành 100 lần tính bình phương!");
        }
    }
}
