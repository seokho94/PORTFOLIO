using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Slider Mpbarstaus;
    [SerializeField] IngameMenu IngameMenu;

    private float maxMp = 100;
    private float curMP = 100;
    
    void Start()
    {
        Mpbarstaus.value = (float)curMP / (float)maxMp;
    }

    void Update()
    {
        if (IngameMenu.igMenuOn == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (curMP <= 5)
                {
                    Debug.Log("마나가 부족합니다.");
                }
                else
                {
                    Debug.Log("스킬을 사용했습니다.");
                    curMP -= 5;
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (curMP == maxMp)
                {
                    Debug.Log("MP가 가득찼습니다.");
                }
                else if (curMP + 20 > maxMp)
                {
                    curMP = maxMp;
                    Debug.Log("MP가 가득찼습니다.");
                }
                else
                {
                    curMP += 20;
                    Debug.Log("MP를 회복했습니다.");
                }
            }


            if (curMP != maxMp) { mprecovery(); }

            MpbarValue();
        }
    }

    private void MpbarValue()
    {
        Mpbarstaus.value = (float)curMP / (float)maxMp;
    }

    public void mprecovery()
    {
        if (curMP != maxMp)
        {
            curMP += Time.deltaTime * 1f;

            if (curMP > maxMp)
            {
                curMP = maxMp;
                Debug.Log("Full MP");
            }
            Mpbarstaus.value = (float)curMP / (float)maxMp;
        }
        else
        {
            Debug.Log("Full MP");
            return;
        }
    }
}



