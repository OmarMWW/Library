class Movies : Mediatype
{
    public Movies(string name, string description, int price) : base(name, description, price)
    {
        
    }

    public Movies() : base()
    {
        
    }

    public override string Get_media_Type()
    {
        return "Movies";
    }
}
