using Newtonsoft.json;

public class Item
{
    //Integer representing an Item's sku number
    private int sku;

    //Integer representing an Item's store number
    private int store;

    /**
    Make a new Item
    @param sku: the sku number of an Item
    @param store: the store number of an Item
    */
    public Item(int sku, int store){
        this.sku = sku;
        this.store = store;
    }

    // Get item Location.
    Array getItemLocation()
    {
        var client = new RestClient("https://api.wegmans.io/products/{sku}/locations/{store}?api-version=2018-10-18&Subscription-Key=50bf72311a614f5e93ec2c194104a8ff", this.sku, this.store);
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
        ItemLocation itemLocation = JsonConvert.DeserializeObject<ItemLocation>(response.Content)
        location = new Array
        location.add(itemLocation.name)
        location.add(itemLocation.aisleSide)
        location.add(itemLocation.shelfNumber)
        return location;
    }


    public static Main(){
        Item item1 = new Item(222,14);
        Array location = Item.getItemLocation();
        Console.WriteLine(location.ToString());
    }
}