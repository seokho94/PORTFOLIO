using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject InventoryUI;
    public GameObject MainMenu;
    private void Update()
    {
        if (InputManager.Instance.GetButtonDown("INVENTORY"))
        {
            InventoryUI.SetActive(!InventoryUI.activeSelf);
        }
    }
}
