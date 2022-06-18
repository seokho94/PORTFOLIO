using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuickSlotControll : MonoBehaviour
{
    [SerializeField] GameObject quickslot;
    public static Slot[] quickslots;

    // Start is called before the first frame update
    void Start()
    {
        quickslots = quickslot.GetComponentsInChildren<Slot>();
    }

    //아이템 개수 매칭
    public void MathcingItem(Item _item)
    {
        Debug.Log("MathcingItem 실행");
        if (_item.GetItemType() != Item.ItemType.Equipment && _item.GetItemType() != Item.ItemType.Weapon)
        {
            for (int i = 0; i < quickslots.Length; i++)
            {
                if (quickslots[i] != null && quickslots[i].item == _item)
                {
                    quickslots[i].itemCount = GameObject.Find("Canvas").GetComponent<Inventory>().ResearchItemcountData(_item);
                    Debug.Log("quickslots[]의 아이템 카운트 : " + quickslots[i].itemCount);
                    quickslots[i].text_Count.text = quickslots[i].itemCount.ToString();
                    if (quickslots[i].itemCount <= 0)
                    {
                        quickslots[i].GetComponent<Slot>().ClearSlot();
                    }
                }
            }
        }
    }

    //동일 아이템 있는지 확인 -> 동일 아이템 존재시 인덱스 값 반환
    public int SearchQuickslots(Item _item)
    {
        for(int i=0; i < quickslots.Length; i++)
        {
            if(quickslots[i].item != null)
            {
                if (quickslots[i].item.GetName() == _item.GetName())
                {
                    return i;
                }
            }
        }
        return -1;
    }

    //해당 인덱스값 초기화
    public void Change(int i)
    {
        quickslots[i].ClearSlot();
    }
}

