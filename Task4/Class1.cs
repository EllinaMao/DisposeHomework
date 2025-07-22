using System;
using System.Diagnostics;

public class MemoryAllocator : IDisposable
{
    private object[] data;
    private bool disposed = false;
    private Stopwatch stopwatch = new Stopwatch();

    public void Allocate(int size = 1000000)
    {
        Console.WriteLine($"[Allocate] Allocating {size} objects...");
        data = new object[size];
        for (int i = 0; i < size; i++)
        {
            data[i] = new byte[100];
        }

        Console.WriteLine($"[Allocate] Generation of first object: {GC.GetGeneration(data[0])}");
    }

    public void SimulateMemoryUse()
    {
        Console.WriteLine("[SimulateMemoryUse] Simulating memory usage...");
        for (int i = 0; i < 10000; i++)
        {
            var temp = new byte[1000];
        }
    }

    public void CollectAndReport()
    {
        Console.WriteLine("[CollectAndReport] Forcing garbage collection...");

        stopwatch.Restart();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        stopwatch.Stop();

        Console.WriteLine($"[GC] Time taken for collection: {stopwatch.ElapsedMilliseconds} ms");

        if (data != null)
        {
            Console.WriteLine($"[GC] Generation after collection: {GC.GetGeneration(data[0])}");
        }
    }

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine("[Dispose] Freeing managed resources...");
            data = null;
            disposed = true;
        }
        GC.SuppressFinalize(this);
    }

    ~MemoryAllocator()
    {
        Console.WriteLine("[Finalizer] MemoryAllocator finalized.");
        Dispose();
    }
}
