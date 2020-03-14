using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryModel playerInventoryModel;
    
    // Start is called just before any of the Update methods is called the first time
    void Start()
    {
        playerInventoryModel = GetComponent<PlayerInventoryModel>();
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            Pickup item = collision.GetComponent<Pickup>();
            if(item.type.ToString() == "Star")
                playerInventoryModel.AddStar();
            Destroy(collision.gameObject);
        }
    }
    
}
