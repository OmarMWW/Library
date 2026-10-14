
class Books : Mediatype
{
    public Books(string name, string description, int price) : base(name, description, price)
    {
    }

    public Books() : base()
    {
    
    }

    public override string Get_media_Type()
    {
        return "Books";
    }
}
