using JsonConvert.DeserializeObject;

/**
    Coupon information
    @author: DogematicShoppers
*/

public class coupons
{
    public void generateCoupon(string cType) //cType is coupon Type
    {
        
    }

    public bool checkForPromo(Item item)
    {
        var client = new RestClient(string.format("https://api.wegmans.io/products/{sku}/prices/{store}?api-version=2018-10-18&Subscription-Key=50bf72311a614f5e93ec2c194104a8ff", item.sku, item.store));
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
        Promotion promo = JsonConvert.DeserializeObject<Promotion>(response.Content);
        if(promo.promotion == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public double savings(Item item)
    {
        bool isPromo = checkForPromo(item);
        if(isPromo)
        {
            var client = new RestClient(string.format("https://api.wegmans.io/products/{sku}/prices/{store}?api-version=2018-10-18&Subscription-Key=50bf72311a614f5e93ec2c194104a8ff", item.sku, item.store));
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Savings savings = JsonConvert.DeserializeObject<Savings>(response.Content);
            return savings.price - savings.promotion.price;
        }
        else
        {
            return 0;
        }
    } 
}