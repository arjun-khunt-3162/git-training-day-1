Thread thread1 = new(new ThreadStart(HighCpuUsageTask));
Thread thread2 = new(new ThreadStart(HighCpuUsageTask));

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

static void HighCpuUsageTask()
{
    for (int i = 0; i < 1000000000; i++)
    {
        // Simulate high CPU usage
        double result = Math.Sqrt(i);
    }
}
