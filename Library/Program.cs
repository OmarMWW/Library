using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your library !");
            Console.WriteLine();
            Console.WriteLine("[1] Add media to your library");
            Console.WriteLine("[2] Show your media");
            Console.WriteLine("[3] Save your media");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addmedia();
                    break;

                case 2:
                    Showmedia();
                    break;
                case 3:
                    Save(Library.GetMedias());
                    break;
            }
        }
    }
        public static void Showmedia()
        {

        List<Mediatype> medias = Library.GetMedias();

        foreach (Mediatype mediatype in medias)
        {
            Console.WriteLine(mediatype.Name + ", " + mediatype.Description + ", " + mediatype.Price + ", (" + mediatype.Get_media_Type() + ")");
        }

        Console.ReadKey();

        }

     public static void Addmedia()
    {
        Console.Clear();
        Console.WriteLine("Add your type of media");
        Console.WriteLine();
        Console.WriteLine("[1] Movie\n[2] Book\n[3] Videogame\n[4] Newspaper\n[5] Audiobooks");
        Mediatype temp = null;

        int Mediachoice = Convert.ToInt32(Console.ReadLine());
        switch (Mediachoice)
        {
            case 1:
                temp = new Movies();
                break;
            case 2:
                temp = new Books();
                break;
            case 3:
                temp = new Videogames();
                break;
            case 4:
                temp = new Newspaper();
            break;
                case 5:
                temp = new Audiobooks();
                break;
        }
    }

    public static void Save(List<Mediatype> medias)
    {
        string jsonData = JsonSerializer.Serialize(medias);
        File.WriteAllText("data.json", jsonData);
    }

}
