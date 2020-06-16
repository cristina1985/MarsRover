using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            Orchastrator orchestrator = new Orchastrator();
            bool firstRun = true;
            while(firstRun)
            {
                var continuation = orchestrator.Run();
                if (continuation == ContinuationType.Stop)
                    firstRun = false;
            }
        }
    }
}