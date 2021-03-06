using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] public GameObject obj_inventory;
    [SerializeField] public GameObject obj_slot;

    private Slot[] slots;
    public static string[] InventoryItem;
    public static int[] InventoryItemCount;

    public static bool isOpen = false;

    void Start()
    {
        obj_inventory.SetActive(false);
        slots = obj_slot.GetComponentsInChildren<Slot>();
        InventoryItem = new string[slots.Length];
        InventoryItemCount = new int[InventoryItem.Length];
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (isOpen == false)
            {
                Inventory_Open();
            }
            else Inventory_Close();
        }
    }

    public void Inventory_Open()
    {
        obj_inventory.SetActive(true);
        isOpen = true;
    }

    public void Inventory_Close()
    {
        obj_inventory.SetActive(false);
        isOpen = false;
    }

    public bool AcquireItem(Item _item, int _count)
    {
        if (Item.ItemType.Equipment != _item.GetItemType() && Item.ItemType.Weapon != _item.GetItemType() && Slot.isDiv==false)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.name == _item.name)
                    {
                        slots[i].SetSlotCount(_count);
                        ReplaceInventoryItemData(_item, _count);
                        return true;
                    }
                }
            }
        }
 
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].AddItem(_item, _count);
                SetInventoryData(_item);
                return true;
            }
            else if(i==slots.Length-1 && slots[i].item != null)
            {
                Debug.Log("인벤토리가 꽉 찼습니다.");
                return false;
            }
        }

        return false;
    }
    public void SetInventoryData(Item _item)
    {
        if (_item.GetItemType() != Item.ItemType.Weapon && _item.GetItemType() != Item.ItemType.Equipment)
        {
            for (int i = 0; i < InventoryItem.Length; i++)
            {
                if (InventoryItem[i] == null)
                {
                    InventoryItem[i] = _item.GetName();
                    InventoryItemCount[i]++;
                    return;
                }
            }
        }
        else
        {
            for (int i = 0; i < InventoryItem.Length; i++)
            {
                if (InventoryItem[i] == null)
                {
                    InventoryItem[i] = _item.GetName();
                    InventoryItemCount[i] = 1;
                    return;
                }
            }
        }
    }

    public void ReplaceInventoryItemData(Item _item, int _itemCount)
    {
        for (int i = 0; i < InventoryItem.Length; i++)
        {
            if (InventoryItem[i] == _item.GetName())
            {
                if (Slot.isMin)
                {
                    InventoryItemCount[i] -= _itemCount; //-> 아이템 사용 및 드랍시
                    if (InventoryItemCount[i] <= 0)
                    {
                        InventoryItem[i].Remove(i);
                    }
                }
                else
                {
                    InventoryItemCount[i] += _itemCount; //-> 아이템 추가시
                }
                return;
            }
        }
    }

    //아이템 개수 검색 후 반환
    public int ResearchItemcountData(Item _item)
    {
        for (int i = 0; i < InventoryItem.Length; i++)
        {
            if (InventoryItem[i] == _item.GetName())
            {
                Debug.Log("ResearchItemcountData : " + InventoryItemCount[i]);
                return InventoryItemCount[i];
            }
        }
        return 0;
    }
}
