using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <sumary>
        /// This is the main sample comment
        /// </sumary>
        /// <param name="args">The arguments</param>
        /// <returns>No Return Value</returns>
        static void Main(string[] args)
        {
            // Single line comment
            Console.WriteLine("Hello World!");
            /* Multiple line comments
            can be used to provide documentation
            in multi-line comments */
        }
    }
}
