using System;
using System.Diagnostics;
using System.Threading;

namespace recordCtrl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test if input arguments were supplied.
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a Recording Time.");
                Console.WriteLine("Usage: RecCtrl <num>");
                return;
            }

            // Try to convert the input arguments to numbers. This will throw
            // an exception if the argument is not a number.
            // num = int.Parse(args[0]);
            int sleepTime;
            bool ret = int.TryParse(args[0], out sleepTime);
            if (!ret)
            {
                Console.WriteLine("Please enter a numeric argument.");
                Console.WriteLine("Usage: RecCtrl <num>");
                return;
            }

            sleepTime *= 1000;

            //Process exeProcess = Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"https://www.ebs.co.kr/onair?channelCodeString=radio");
            //Process exeProcess = Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", @"https://www.ebs.co.kr/onair?channelCodeString=radio");
            Process exeProcess = Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", @"https://www.ebs.co.kr/onair?channelCodeString=iradio");

            /*
            Console.WriteLine("ID: {0}", exeProcess.Id);
            
            Process[] processes = Process.GetProcessesByName("chrome");
            Console.WriteLine("{0} Chrome processes", processes.Length);
            */

            Thread.Sleep(sleepTime);


            Process.Start("taskkill", "/IM firefox.exe");
            /*
            Array.ForEach(processes, (process) =>
            {
                // Console.WriteLine("Process: {0} Id: {1}", process.ProcessName, process.Id);

                if (process.Id==exeProcess.Id)
                {
                    process.Kill();
                    Console.WriteLine("Hello");
                }
            });*/



            //exeProcess.Kill();

        }

        // Call WaitForExit and then the using statement will close.
        /*
        {
            if (!exeProcess.WaitForExit(1000))
                exeProcess.Kill();
        }
        */
    }
}


