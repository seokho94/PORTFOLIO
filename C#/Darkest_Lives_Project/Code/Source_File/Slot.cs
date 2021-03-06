using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour , IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{

    public Item item; //획득 아이템
    public int itemCount; //획득 아이템 갯수
    public Image itemImage; //아이템 이미지
    public static bool isDrop;
    public PlayerMove playerMove;
    private Vector3 plusvec = new Vector3(1, 1, 1);
    public static bool isDiv;
    public static bool isMin;

    //필요컴포넌트
    public TextMeshProUGUI text_Count;
    [SerializeField] private GameObject image_Count;
    [SerializeField] private GameObject SelectImage;

    public void Start()
    {
        isDrop = false;
        isDiv = false;
        isMin = false;
    }

    public void Update()
    {
        if(Inventory.isOpen && Input.GetKeyDown(KeyCode.CapsLock))
        {
            isDiv = true;
        }
        else if(Inventory.isOpen && Input.GetKeyUp(KeyCode.CapsLock))
        {
            isDiv = false;
        }
    }

    //이미지 알파값 조절
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    //아이템 획득
    public void AddItem(Item _item, int _count = 1)
    {
        item = _item;
        itemCount = _count;
        itemImage.sprite = item.GetImage();
        if(item.GetItemType() != Item.ItemType.Equipment && item.GetItemType() != Item.ItemType.Weapon)
        {
            image_Count.SetActive(true);
            text_Count.text = itemCount.ToString();
        }
        else
        {
            text_Count.text = "0";
            image_Count.SetActive(false);
        }
        SetColor(1);
    }

    //아이템 갯수 조정
    public void SetSlotCount(int _count)
    {
        itemCount += _count;
        text_Count.text = itemCount.ToString();

        if(itemCount <= 0)
        {
            ClearSlot();
        }
    }

    //슬롯 클리어
    public void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);

        text_Count.text = "0";
        image_Count.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if(item != null)
            {
                //무기나 장비면 장착
                if(item.GetItemType() == Item.ItemType.Equipment || item.GetItemType() == Item.ItemType.Weapon)
                {

                }
                //그 외에는 소모
                else
                {

                }
            }
        }
        //아이템 나누기
        if (isDiv && eventData.button == PointerEventData.InputButton.Left)
        {
            if (CompareTag(DragSlot.instance.tag))
            {
                int divCount = 0;

                //장비 아이템 제외
                if (item.GetItemType() != Item.ItemType.Weapon && item.GetItemType() != Item.ItemType.Equipment)
                {
                    //아이템 갯수가 2개 이상일때만 실행
                    if (itemCount > 1)
                    {
                        //아이템 갯수가 홀수일 때 연산
                        if (itemCount % 2 != 0)
                        {
                            divCount = itemCount % 2 + itemCount / 2;
                            itemCount = itemCount - divCount;
                        }
                        else
                        {
                            divCount = itemCount / 2;
                            itemCount = divCount;
                        }
                        AddItem(item, itemCount);
                        GameObject.Find("Canvas").GetComponent<Inventory>().AcquireItem(item, divCount);
                    }

                    else
                    {
                        Debug.Log("아이템 갯수가 부족합니다.");
                    }
                }
                else
                {
                    Debug.Log("나눌 수 없는 아이템입니다.");
                }
            }
            else
            {
                Debug.Log("퀵슬롯은 나눌 수 없습니다.");
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (item != null)
        {
                SelectImage.SetActive(true);
                DragSlot.instance.dragSlot = this;
                DragSlot.instance.DragSetImage(itemImage);
                DragSlot.instance.transform.position = eventData.position;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (item != null)
        {
            DragSlot.instance.transform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isDrop)
        {
            if (!CompareTag(DragSlot.instance.tag))
            {
                ClearSlot();
            }

            else if (CompareTag(DragSlot.instance.tag))
            {
                isMin = true;
                Debug.Log(item.name);
                GameObject obj = ObjectManager.Instance.GetObject(item.name);
                obj.transform.position = GameObject.Find("Player").transform.position + plusvec;
                obj.SetActive(true);
                GameObject.Find("Canvas").GetComponent<Inventory>().ReplaceInventoryItemData(DragSlot.instance.dragSlot.item, DragSlot.instance.dragSlot.itemCount);
                GameObject.Find("Canvas").GetComponent<QuickSlotControll>().MathcingItem(DragSlot.instance.dragSlot.item);
                ClearSlot();
            }
        }

        SelectImage.SetActive(false);
        DragSlot.instance.SetColor(0);
        DragSlot.instance.dragSlot = null;
      
        isDrop = false;
        isDiv = false;
        isMin = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        isDrop = true;
        if (DragSlot.instance.dragSlot != null)
        {
                CompareSlot();
        }
    }

    public void CompareSlot()
    {
        if (CompareTag(DragSlot.instance.dragSlot.tag))
        {
            if(item == DragSlot.instance.dragSlot.item)
            {
                Item tmpitem = item;
                int tmpitemCount = itemCount;

                AddItem(DragSlot.instance.dragSlot.item, DragSlot.instance.dragSlot.itemCount+ tmpitemCount);
                DragSlot.instance.dragSlot.ClearSlot();
            }
            else
            {
                ChangeSlot();
            }
        }
        else
        {
            if (DragSlot.instance.dragSlot.CompareTag("Slot"))
            {
                CoppySlot();
                GameObject.Find("Canvas").GetComponent<QuickSlotControll>().MathcingItem(DragSlot.instance.dragSlot.item);
            }
        }
    }

    //동일 태그 슬롯에서 위치 변경
    private void ChangeSlot()
    {
        Item _tmpItem = item;
        int _tmpItemCount = itemCount;

        AddItem(DragSlot.instance.dragSlot.item, DragSlot.instance.dragSlot.itemCount);

        if(_tmpItem != null)
        {
            DragSlot.instance.dragSlot.AddItem(_tmpItem, _tmpItemCount);
        }
        else
        {
            DragSlot.instance.dragSlot.ClearSlot();         
        }
    }

    //인벤토리 -> 퀵슬롯 이동시 복사
    private void CoppySlot()
    {
        if (GameObject.Find("Canvas").GetComponent<QuickSlotControll>().SearchQuickslots(DragSlot.instance.dragSlot.item) >= 0)
        {
            GameObject.Find("Canvas").GetComponent<QuickSlotControll>().Change(GameObject.Find("Canvas").GetComponent<QuickSlotControll>().SearchQuickslots(DragSlot.instance.dragSlot.item));
            AddItem(DragSlot.instance.dragSlot.item, DragSlot.instance.dragSlot.itemCount);
        }
        else
        {
            AddItem(DragSlot.instance.dragSlot.item, DragSlot.instance.dragSlot.itemCount);
        }
    }
}
