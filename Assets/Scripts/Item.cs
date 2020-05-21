using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemObject item;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            
            {
                ScoreScript.itemValue += 1;
            }
    }





}
