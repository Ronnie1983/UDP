using System;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.start();
        }
    }
}
