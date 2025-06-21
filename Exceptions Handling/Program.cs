using System;
using Serilog;
class Program
{
    static void Main()
    {
        long.Logger = new LoggerConfiguration().MinimumLevel.Debug().writeTo.Console().CreateLogger();

        long.Information("Hello, Serilog");

    }
}

public class CustomException : Exception
{
    public CustomException(string message) : base(message){}
}