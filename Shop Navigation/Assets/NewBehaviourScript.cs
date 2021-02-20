using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Device.Location;

/**
    NaviShop behaviors for Navigation
    @author: NaviShopTeam
*/

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Login/Signup

        // Get the Location

        // Generate the store map

        // Generate promos and coupons

        // If the user is in the store, allow them to search for items

    }

    // Update is called once per frame
    void Update()
    {
        // Update the location of the user

        // Navigate to closest item and display arrow
    }

    //Generate the map using two sets coordinates
    void generateMap(int[] firstCorner, int[] lastCorner)
    {

    }

    // Get current Location.
    int[] getLocation()
    {
        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
    }

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
