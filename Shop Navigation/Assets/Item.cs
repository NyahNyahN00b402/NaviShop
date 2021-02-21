public class Item
{
    // Get item Location.
    string getItemLocation(int[] sku, int[] store)
    {
        var client = new RestClient("https://api.wegmans.io/products/categories/561-562?Subscription-Key=50bf72311a614f5e93ec2c194104a8ff&api-version=2018-10-18");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
    }
}