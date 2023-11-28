namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JellyBeanCollection jellyBeanCollection = new JellyBeanCollection();
            Random rnd = new Random();
            string[] list = { "Cherry", "Bubble Gum", "Root Beer", "Licorice", "French Vanilla" };
            for (int i = 0; i < 100; i++)
            {
                jellyBeanCollection[i] = new JellyBean(list[rnd.Next(0, list.Length)]);
            }
            jellyBeanCollection[100] = new Tomas("Tomas");
            JellyBeanIterator iterator = new JellyBeanIterator(jellyBeanCollection);

            Console.WriteLine("Gimme all the jelly beans!");

            for (JellyBean item = iterator.First();
                !iterator.IsDone; 
                item = iterator.Next())
                if (iterator.CurrentBean is Tomas)
                    Console.WriteLine("Tomas is not a jelly bean!");
                else
                    Console.WriteLine("Tomas is a jelly bean!");

        }

    }
}