using System;
using System.Collections.Generic;

public class Mapping 
{
    // The corners of the store
    private int[] corner1 = new int[2];
    private int[] corner2 = new int[2];
    private List<int> aisles;


    // Constructor for mapping
    public Mapping(int[] corner1, int[] corner2, List<int> aisles){
        this.corner1 = corner1;
        this.corner2 = corner2;
        this.aisles = aisles;
    }

    // Behaviors
    /// <summary> Returns the corner1 and corner2 of the map </summary>
    /// <return> int[] </return>
    public int[] generateMap()
    {
        int[] coords = {this.corner1,this.corner2};
        return  coords;
    }

    /// <summary> Returns the aisle at index </summary>
    public getAisle(int longitude, int latitude)
    {

    }

    //getItemLocation(sku, storeNumber)
}