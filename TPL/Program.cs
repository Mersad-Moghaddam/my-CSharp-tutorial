using System;
namespace Thread
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }

    class Program
    {
        static List<Student> GetStudentData() => Enumerable.Range(1, 10).Select(
            i => new Student()
            {
                ID = i,
                Name = $"Student-{i}"
            }
        ).ToList();


        static async Task<int> ProcessStudentAsync(Student student)
        {
            await Task.Delay(100);
            Console.WriteLine($"Processing Data for {student.Name}");
            return student.ID * 2;

        }

        static async Task Main()
        {
            Console.Clear();
            
            var students = GetStudentData();
            var results = await Task.WhenAll(students.Select(ProcessStudentAsync));
            Console.WriteLine($"Total Process Data : {results.Sum()}");
            
        }
    }
}