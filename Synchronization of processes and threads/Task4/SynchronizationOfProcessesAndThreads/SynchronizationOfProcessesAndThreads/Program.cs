using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

int[] buffer = new int[10];
int producer = 2000;
int consumer = 2000;

void Producer()
{
    while (true)
    {
        Random random = new Random();
        
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = random.Next(10);
        }

        foreach (var items in buffer)
        {
            Console.WriteLine(items);
        }

        Thread.Sleep(producer);
    }
}

void Consumer()
{
    Thread.Sleep(consumer);
}


Thread producerThread = new Thread(Producer);
producerThread.Start();
