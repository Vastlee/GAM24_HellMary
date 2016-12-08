﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<GameObject> Slots = new List<GameObject>();
    public List<Item> Items = new List<Item>();
    public GameObject slots;
    int x = -240;
    int y = 200;

    // Use this for initialization
    void Start()
    {
        for (int i = 1; i < 6; i++)
        {
            for (int k = 1; k < 6; k++)
            {
                GameObject slot = (GameObject)Instantiate(slots);
                Slots.Add(slot);
                Items.Add(new Item());
                slot.transform.parent = this.gameObject.transform;
                slot.name = "slot" + i + "." + k;
                slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
                x = x + 100;
                if(k == 5)
                {
                    x = -240;
                    y = y - 100;
                }
            }
        }
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
