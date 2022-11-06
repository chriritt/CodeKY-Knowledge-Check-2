namespace CodeKY_Knowledge_Check_2
    {

    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine(" ██████╗  █████╗ ███╗   ███╗███████╗    ██╗     ██╗███████╗████████╗\r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██║     ██║██╔════╝╚══██╔══╝\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║     ██║███████╗   ██║   \r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║     ██║╚════██║   ██║   \r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ███████╗██║███████║   ██║   \r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝    ╚══════╝╚═╝╚══════╝   ╚═╝   \r\n                                                                    ");

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());



            var gameList = new List<Game>();
            for (int i = 0; i < numberOfRecords; i++)
                {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new Game();

                Console.WriteLine("Name of Game: ");
                entry.gameName = Console.ReadLine();

                Console.WriteLine("Enter the Genre: ");
                entry.genre = Console.ReadLine();

                gameList.Add(new Game() { gameName = entry.gameName, genre = entry.genre });
                }

            // Print out the list of records using Console.WriteLine()
            foreach (var entry in gameList)
                Console.WriteLine("\n\rGame: " + entry.gameName.ToUpper() + "\nGenre: " + entry.genre.ToUpper() + "\n\r");
            }
        }
    }