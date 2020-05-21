using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject inventoryUI;
    private bool inventoryEnabled;

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }


    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.Save();

        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            inventory.Load();
        }
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;

            if (inventoryEnabled == true)
            {
                inventoryUI.SetActive(true);
            } else
            {
                inventoryUI.SetActive(false);
            }
        }
    }

}
