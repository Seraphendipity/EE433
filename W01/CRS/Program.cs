using System;

namespace CRS
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course("EE", 123, "A fun course");
            Course course2 = new Course("EE", 123, "A fun course");
            Course course3 = new Course("EE", 123, "A fun course");
            Console.WriteLine($"Hello World! {course3.id}");
        }
    }
}
