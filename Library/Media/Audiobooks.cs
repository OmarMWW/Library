class Audiobooks : Mediatype
{
    public Audiobooks(string name, string description, int price) : base(name, description, price)
    {
    }

    public Audiobooks() : base()
    {

    }

    public override string Get_media_Type()
    {
        return "Audiobooks";
    }
}
