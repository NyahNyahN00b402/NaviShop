/**
    Store information.
    @author: Pathetic Shoppers
*/
public class Stores
{
    public List<StoreLocation> stores {get; set;}
}

public class StoreLocation
{
    public int number {get; set;}
}

public class StoreLongLat
{
    public long latitude {get; set;}
    public long longitude {get; set;}
}