class Phone
{
    private int _id;
    private string _name;
    private string _brandname;
    private double _price;
    private int _count;


    public int Id 
    {
        get
        {
            return _id;
        }
        set
        {
            if (value>0) 
            {
            _id = value;
            }
        }
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            value = value.Trim();
            if (value.Length > 1)
            {
                _name = value;
            }

        }
    }

    public string BrandName {
        get
        {
            return _brandname;
        }
        set
        {
            value=value.Trim();
            if (value.Length > 2)
            {
            _brandname=value;
            }

        }
    }
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value > 0)
            {
                _price = value;
            }
        }
    }
    public int Count
    {
        get
        {
            return _count;
        }
        set
        {
            if (value > 0)
            {
                _count = value;
            }
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id} \nName: {Name}\nBrand: {BrandName}\nPrice: {Price}\nCount: {Count}");
    }
}
