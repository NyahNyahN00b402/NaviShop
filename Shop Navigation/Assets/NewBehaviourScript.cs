using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Device.Location;

// Custom Classes
using Mapping;
using Customer;
using Item;
using ItemLocation;
using ShoppingList;
using Coupons;

/**
    NaviShop behaviors
    @author: PatheticShoppers
*/

public class NewBehaviourScript : MonoBehaviour
{
    // class variables
    private static int[] COOR1 = {1,10} //temp values!
    private static int[] COOR1 = {10,1} //temp values!
    Customer customer = new Customer();
    Mapping mapping = new Mapping(COOR1, COOR2)

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
        // if the customer is navigating, update the screen with an arrow pointing in the direction that they need to go
        if(customer.isNavigating())
        {

        }
        
    }
}
