
/**
    Customer information
    @author: DogematicShoppers
*/

public class Customer
{
    private int[] currentLocation;

    // Checks if the customer is navigating
    public bool isNavigating(){
        return false;
        // IMPLEMENT REST OF FUNCTION
    }

    // Login/Signup.
    void promptLogin(){

    }

    // Get current Location.
    int[] getLocation()
    {

    }

    // Have the user enter in the store location
    void promptLocation()
    {

    }
    
    // Ask for location access. Suggest nearest store.
    void suggestLocations()
    {
        var client = new RestClient("https://api.wegmans.io/stores?api-version=2018-10-18&subscription-key=50bf72311a614f5e93ec2c194104a8ff");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse stores = client.Execute(request);
        Console.WriteLine(stores.Content);
        
    }
}