using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public Item item;

    public List<Item> items = new List<Item>();

    public void Add(BaseItem item)
    {
        items.Add(item);
    }

    public void Remove()
    {
        (items item)
        {
            items.Remove(item);
        }
    }
}
