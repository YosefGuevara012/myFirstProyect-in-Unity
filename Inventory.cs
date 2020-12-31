using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<T> {

    private T _item;

    private T Item
    {
        get
        {
            return _item;
        }
        set
        {
            _item = value;
        }
    }

    public Inventory()
    {
        Debug.Log("Inventario creado");
    }


    public void SetItem (T newItem)
    {
        Item = newItem;
    }
}

    
