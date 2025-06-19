using System;
namespace SingletonPatternExample
{
    class Logger
    {
        private static Logger _instance;
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }
        public static Logger getInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }
    public class Singleton
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.getInstance();
            Logger logger2 = Logger.getInstance();
            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger1 and logger2 are the same instance. Therefore, the Singleton pattern is working correctly.");
            }
        }
    }
}