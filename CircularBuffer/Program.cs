using System;
namespace CircularBuffer
{
   
    class Program
    {
        static void Main(string[] args)
        {
            CircularBuffer<double> buffer = new CircularBuffer<double>(capacity:3);
            while (true)
            {
                string input = Console.ReadLine();
                var value=0.0;
                if (input != "")
                {
                    if (input.Contains("."))
                    {
                        input=input.Replace(".",","); 
                    }
                    value = double.Parse(input);
                    buffer.Write(value);
                }
                else
                    break;
            }
                Console.Write("Buffer: ");
                double sum = 0.0;
                while(!buffer.IsEmpty)
                {
                    double a = buffer.Read();
                    Console.Write(a + " ");
                    sum += (double)a;
                }
                Console.WriteLine();
                Console.WriteLine("Sum is:" + sum);
            
        }
    }
}
