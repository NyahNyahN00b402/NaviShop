/**
    Shopping list information
    @author: PatheticShoppers
*/

using System;
using System.Collections.Generic;

public class ShoppingList 
{
    private List<Item> list = new List<Item>();

    public void addToList(Item item){
        list.append(item);
    }

    public void rmFromList(Item item){
        list.remove(item);
    }
}