using JsonConvert.DeserializeObject;
using Math;
using System;
using System.Collections.Generic;
using System.Device.Location;

/**
    Customer information
    @author: DogematicShoppers
*/

public class Customer
{
    private int[] currentLocation;
    private string user;
    private string password;

    // Checks what direction the customer is travelling
    public bool isNavigating(string direction){
        if (direction != "forward" || direction != "right" || direction != "left" || direction != "backward"){
            return false;
        }
        return true;
    }

    // Login/Signup.
    void promptLogin(){
        // new variables for Login
        string prompt_user;
        string prompt_password;

        // prompt the user for their user name

        // check if the user name is in the database and compares hashed passwords
        this.user = prompt_user;
        this.password = prompt_password;    //this should be hashed if we implement it
    }

    // Get current Location.
    int[] getLocation()
    {
        // get the coordinates of the customer from the device they are holding
        GeoCoordinateWatcher watcher;

        watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));   // leave watcher open if not immediate response
        GeoCoordinateWatcher coord = watcher.Position.Location;

        int[] coords = {coord.Latitude, coord.Longitude};

        return coords;

    }

    // Have the user enter in the store location
    void promptLocation()
    {

    }
    
    // Ask for location access. Suggest nearest store.
    void suggestLocations(long userLat, long userLong)
    {
        Array<Integer> storesxy = new Array();
        var client = new RestClient("https://api.wegmans.io/stores?api-version=2018-10-18&subscription-key=50bf72311a614f5e93ec2c194104a8ff");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse stores = client.Execute(request);
        Console.WriteLine(stores.Content);
        Stores stores = JsonConvert.DeserializeObject<Stores>(stores.Content);
        foreach(Stores store in stores) // I changed this, but I don't really know what type of information is stored in each iteration of Stores !!!!!!!!!!!!!!!!!!!!!
        {
            StoreLocation storeNum = JsonConvert.DeserializeObject<StoreLocation>(store);
            var client = new RestClient(string.format("https://api.wegmans.io/stores/{storeNum}?api-version=2018-10-18&subscription-key=50bf72311a614f5e93ec2c194104a8ff", storeNum));
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            StoreLongLat xy = JsonConvert.DeserializeObject<StoreLongLat>(response.content);
            storesxy.add(xy);
        }
        foreach(int xy in storesxy)
        {
            if(Math.abs(xy.latitude - userLat) <= 0.5 && Math.abs(xy.longitude - userLong) <= 0.5)
            {
                int suggestedStore = storesxy.indexOf(xy) + 1;
            }
        }
    }
}