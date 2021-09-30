using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShortCut : MonoBehaviour
{
    Inventory inventory;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (Inventory.isOpen)
            {
                inventory.Inventory_Close();
            }
            else inventory.Inventory_Open();
        }
    }
}
