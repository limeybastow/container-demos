using System;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
                .WriteTo.ColoredConsole();

            string seqUrl = Environment.GetEnvironmentVariable("SEQ_URL");
            Console.Write($"SEQ_URL - {seqUrl}");

            if (!string.IsNullOrWhiteSpace(seqUrl))
            {
                loggerConfiguration.WriteTo.Seq(seqUrl);
            }

            Log.Logger = loggerConfiguration.CreateLogger();

            int interation = 0;
            Random randomGenerator = new Random();

            try
            {
                while (true)
                {
                    int value = randomGenerator.Next(0, 10);

                    if ((value % 5) == 0) Log.Warning("Value is divisible by 5!");

                    Log.Information($"Iteration {interation++} - {value}");

                    var someValue = 10 / value;

                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Log.Fatal($"Oops!  Something broke!\r\n\r\n{ex.ToString()}");
                Log.CloseAndFlush();
                throw ex;
            }
        }
    }
}
