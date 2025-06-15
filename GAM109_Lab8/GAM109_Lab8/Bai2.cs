using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab8
{
    public static class Bai2
    {
        // Declare the locks as static objects
        private static readonly object lock1 = new object();
        private static readonly object lock2 = new object();

        public static void bai2()
        {
            Console.WriteLine("\n=== BÀI 2: DEADLOCK PREVENTION ===");
            Console.WriteLine("Bắt đầu...\n");

            // Tạo 2 threads có thể gây deadlock
            Thread threadA = new Thread(ThreadA_Method);
            threadA.Name = "ThreadA";

            Thread threadB = new Thread(ThreadB_Method);
            threadB.Name = "ThreadB";

            // Khởi động threads
            threadA.Start();
            threadB.Start();

            // Chờ threads hoàn thành
            threadA.Join();
            threadB.Join();
        }

        static void ThreadA_Method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[ThreadA] Lần {i + 1}: Cố gắng lấy lock1...");

                // Cố gắng lấy lock1 trong 1 giây
                if (Monitor.TryEnter(lock1, TimeSpan.FromMilliseconds(1000)))
                {
                    try
                    {
                        Console.WriteLine($"[ThreadA] Đã lấy được lock1");
                        Thread.Sleep(100); // Mô phỏng công việc

                        Console.WriteLine($"[ThreadA] Cố gắng lấy lock2...");

                        // Cố gắng lấy lock2 trong 1 giây
                        if (Monitor.TryEnter(lock2, TimeSpan.FromMilliseconds(1000)))
                        {
                            try
                            {
                                Console.WriteLine($"[ThreadA] Đã lấy được cả 2 locks - Thực hiện công việc");
                                Thread.Sleep(200); // Mô phỏng công việc
                            }
                            finally
                            {
                                Monitor.Exit(lock2);
                                Console.WriteLine($"[ThreadA] Đã trả lock2");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"[ThreadA] Không thể lấy lock2 - Tránh deadlock!");
                        }
                    }
                    finally
                    {
                        Monitor.Exit(lock1);
                        Console.WriteLine($"[ThreadA] Đã trả lock1");
                    }
                }
                else
                {
                    Console.WriteLine($"[ThreadA] Không thể lấy lock1 - Thử lại...");
                }

                Thread.Sleep(500);
            }
        }

        static void ThreadB_Method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[ThreadB] Lần {i + 1}: Cố gắng lấy lock2...");

                // Cố gắng lấy lock2 trong 1 giây
                if (Monitor.TryEnter(lock2, TimeSpan.FromMilliseconds(1000)))
                {
                    try
                    {
                        Console.WriteLine($"[ThreadB] Đã lấy được lock2");
                        Thread.Sleep(100); // Mô phỏng công việc

                        Console.WriteLine($"[ThreadB] Cố gắng lấy lock1...");

                        // Cố gắng lấy lock1 trong 1 giây
                        if (Monitor.TryEnter(lock1, TimeSpan.FromMilliseconds(1000)))
                        {
                            try
                            {
                                Console.WriteLine($"[ThreadB] Đã lấy được cả 2 locks - Thực hiện công việc");
                                Thread.Sleep(200); // Mô phỏng công việc
                            }
                            finally
                            {
                                Monitor.Exit(lock1);
                                Console.WriteLine($"[ThreadB] Đã trả lock1");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"[ThreadB] Không thể lấy lock1 - Tránh deadlock!");
                        }
                    }
                    finally
                    {
                        Monitor.Exit(lock2);
                        Console.WriteLine($"[ThreadB] Đã trả lock2");
                    }
                }
                else
                {
                    Console.WriteLine($"[ThreadB] Không thể lấy lock2 - Thử lại...");
                }

                Thread.Sleep(500);
            }
        }
    }
}
