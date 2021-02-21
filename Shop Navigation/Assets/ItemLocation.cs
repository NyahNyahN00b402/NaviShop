public class ItemResults
{
    public list<ItemSku> results {get; set;}
}

public class ItemSku
{
    public long sku {get; set;}
}

public class ItemLocation
{
    public string name {get; set;}
    public string aisleSide {get; set;}
    public string shelfNumber {get; set;}
}