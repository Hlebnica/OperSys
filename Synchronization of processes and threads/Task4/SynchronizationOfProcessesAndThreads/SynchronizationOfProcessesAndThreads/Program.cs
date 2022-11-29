using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

List<int> buffer = new List<int>();
int producer = 2000;
int consumer = 2000;

void Producer()
{
    while (true)
    {
        Random random = new Random();
        if (buffer.Count <= 10)
        {
            buffer.Add(random.Next(15));
        }
        Thread.Sleep(producer);
        foreach (var value in buffer)
        {
            Console.WriteLine(value);
        }
    }
}

void Consumer()
{
    Thread.Sleep(consumer);
}

Thread producerThread = new Thread(Producer);
producerThread.Start();
