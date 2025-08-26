
// Amir Moeini Rad
// April 28, 2025

// Main Concept: Singleton Design Pattern

// Four mechanisms: 'sealed class', 'private constructor', 'private readonly field' and 'public static property'
// are used to implement the Singleton pattern.

namespace SingletonExample
{
    // The Logger class is sealed to prevent inheritance, ensuring the Singleton behavior is not compromised.   
    public sealed class Logger
    {
        // A static readonly instance of the class is created, ensuring only one instance exists.
        private static readonly Logger _logger = new Logger();


        // Private constructor ensures that the object is not instantiated other than within the class itself.
        private Logger() 
        {
            Console.WriteLine("\nConstructor: Logger instance created.");
        }


        // Public static property to provide global access point.
        public static Logger Instance
        {
            get
            { 
                Console.WriteLine("Property: In Logger.Instance...");
                return _logger; 
            }
        }


        // Example method
        public void Log(string message)
        {
            Console.WriteLine($"\nLog: {message}\n");
        }
    }


    ///////////////////////////////////////////////


    // Main program to demonstrate the Singleton Design Pattern.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Working with the Singleton Design Pattern in C#.NET...");
            Console.WriteLine("------------------------------------------------------\n");


            Logger logger1 = Logger.Instance;
            logger1.Log("First Message");


            Logger logger2 = Logger.Instance;
            logger2.Log("Second Message");


            // Confirming both references point to the same instance.
            Console.WriteLine($"Are both loggers the same instance? {ReferenceEquals(logger1, logger2)}");


            Console.WriteLine("\nDone!");
        }
    }
}
