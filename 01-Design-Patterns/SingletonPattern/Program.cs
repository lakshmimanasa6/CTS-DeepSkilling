using System;

// Singleton Class
public sealed class Logger
{
    // Single instance
    private static Logger instance = new Logger();

    // Private constructor
    private Logger()
    {
        Console.WriteLine("Logger object created.");
    }

    // Method to access the instance
    public static Logger GetInstance()
    {
        return instance;
    }

    // Logging method
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("Application Started");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("User Logged In");

        if (logger1 == logger2)
        {
            Console.WriteLine("Only one Logger instance exists.");
        }
        else
        {
            Console.WriteLine("Different Logger instances exist.");
        }
    }
}
