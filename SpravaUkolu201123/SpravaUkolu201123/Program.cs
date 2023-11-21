namespace SpravaUkolu201123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleTask completeTask = new SimpleTask("Úkoly");
            SubTask sub1 = new SubTask("Matematika");
            sub1.Add(new SubTask("Sčítání"));
            completeTask.Add(sub1);

            Console.WriteLine("Úkoly:");
            foreach (var item in completeTask.taskComponents)
            {
                Console.WriteLine(item.name);
            }

        }

    }
}