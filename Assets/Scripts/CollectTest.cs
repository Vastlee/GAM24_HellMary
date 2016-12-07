﻿using UnityEngine;
using System.Collections;

public class Digging : MonoBehaviour
{
    public GameObject material;
    public float playerPosition;
    public float maxDist = 2.0f;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        material = GameObject.FindGameObjectWithTag("Block");
        playerPosition = transform.position.x;
    }

    void OnTriggerEnter(Collider gameObject)
    {
        if(material.tag == "Block")
        {
            print("Is Digging");
        }
    }
}