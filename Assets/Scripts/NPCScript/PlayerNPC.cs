﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNPC : MonoBehaviour
{
    private GameObject triggeringNpc;
    private bool triggering;

    public GameObject npcText;

    void Update()
    {
        if (triggering)
        {
            npcText.SetActive (true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Congrats");
            }
        } else
        {
            npcText.SetActive (false);
        }
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = false;
            triggeringNpc = null;
        }
    }
}
