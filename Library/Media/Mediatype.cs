abstract class Mediatype
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public virtual string Get_media_Type()
    {
        return "Invalid";
    }


    public Mediatype(string name, string description, int price)
    {
        Name = name;
        Description = description;
        Price = price;

        Library.AddMedia(this);
    }

    public Mediatype()
    {
        Console.Clear();
        Console.WriteLine("Enter name :");
        Name = Console.ReadLine();
        Console.WriteLine("Write a description:");
        Description = Console.ReadLine();
        Console.WriteLine("Enter price");
        Price = Convert.ToInt32(Console.ReadLine());

        Library.AddMedia(this);
    }
}