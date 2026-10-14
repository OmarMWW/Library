class Videogames : Mediatype
{
    public Videogames(string name, string description, int price) : base(name, description, price)
    {
    }

    public Videogames() : base()
    {

    }

    public override string Get_media_Type()
    {
        return "Videogames";
    }

}

