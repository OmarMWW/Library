class Newspaper : Mediatype
{
    public Newspaper(string name, string description, int price) : base(name, description, price)
    {
    }

    public Newspaper() : base()
    {

    }

    public override string Get_media_Type()
    {
        return "Newspaper";
    }


}
