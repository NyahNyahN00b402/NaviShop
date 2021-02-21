using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Device.Location;
using Mapping;

/**
    NaviShop behaviors
    @author: NaviShopTeam
*/

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Login

        // Get the Location

        // Generate the store map
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Generate the map using two sets coordinates
    void generateMap(int[] firstCorner, int[] lastCorner)
    {

    }

    // Get current Location.
    int[] getLocation()
    {

    }

    // Get item Location.
    Array[] getItemLocation(int[] sku, int[] store)
    {
        var client = new RestClient(string.format("https://api.wegmans.io/products/{sku}/locations/{store}?api-version=2018-10-18&Subscription-Key=50bf72311a614f5e93ec2c194104a8ff", param sku, param store);
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
    }

    // If the current location is within the store, allow the user to search for items

    // Have the user enter in the store location
    void promptLocation()
    {

    }

    // Login/Signup.
    void promptLogin(){

    }

    // Ask for location access. Suggest nearest store.
    void suggestLocations()
    {

    }
}
