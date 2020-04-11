using System;

namespace latihaninheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Leon", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kammarudin", 32, "93312708", "Pemrogramman");
            teacher.GetNameAndAge();

            Student student = new Student("Villa", 19, "2862", "villa.p@students.amikom.ac.id");
            student.GetNameAndAge();

          
            Console.ReadKey();
        }
    }
}
