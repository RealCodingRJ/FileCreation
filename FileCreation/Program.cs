namespace FileCreation
{

    class Program
    {

        private static void Main(string[] _)
        {
            Console.WriteLine("Enter File Name: ");

            var fileName = Console.ReadLine();

            Task task = new(() =>
            {

                if (!File.Exists(fileName))
                {
                    File.Create(fileName ?? "");
                    Console.WriteLine("File Created");
                }

            });

            task.Start();

            Console.ReadLine();

        }

    }
}