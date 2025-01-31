class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Hello from Singleton!");

        Console.WriteLine(Object.ReferenceEquals(logger1, logger2));
    }
}




public class Logger
{
    private static Logger _instance;

    private Logger()
    {
        Console.WriteLine("Logger Instance Created!");
    }

    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}


