using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooldown : MonoBehaviour
{
    [SerializeField] IngameMenu IngameMenu;

    public Image cooltimeImage1;
    public float cooldown1 = 1;
    public bool isCooldown1 = false;
    public KeyCode slot1;

    public Image cooltimeImage2;
    public float cooldown2 = 2;
    public bool isCooldown2 = false;
    public KeyCode slot2;

    public Image cooltimeImage3;
    public float cooldown3 = 7;
    bool isCooldown3 = false;
    public KeyCode slot3;

    public Image cooltimeImage4;
    public float cooldown4 = 4;
    bool isCooldown4 = false;
    public KeyCode slot4;

    public Image cooltimeImage5;
    public float cooldown5 = 5;
    bool isCooldown5 = false;
    public KeyCode slot5;

    public Image cooltimeImage6;
    public float cooldown6 = 4;
    bool isCooldown6 = false;
    public KeyCode slot6;

    public Image cooltimeImage7;
    public float cooldown7 = 15;
    bool isCooldown7 = false;
    public KeyCode slot7;

    public Image cooltimeImage8;
    public float cooldown8 = 10;
    bool isCooldown8 = false;
    public KeyCode slot8;

    // Start is called before the first frame update
    void Start()
    {
        cooltimeImage1.fillAmount = 0;
        cooltimeImage2.fillAmount = 0;
        cooltimeImage3.fillAmount = 0;
        cooltimeImage4.fillAmount = 0;
        cooltimeImage5.fillAmount = 0;
        cooltimeImage6.fillAmount = 0;
        cooltimeImage7.fillAmount = 0;
        cooltimeImage8.fillAmount = 0;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if(IngameMenu.igMenuOn == false)
    //    {
    //        SLOT1();
    //        SLOT2();
    //        SLOT3();
    //        SLOT4();
    //        SLOT5();
    //        SLOT6();
    //        SLOT7();
    //        SLOT8();
    //    }
    //}

    //void SLOT1()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1) && isCooldown1 == false)
    //    {
    //        isCooldown1 = true;
    //        cooltimeImage1.fillAmount = 1;
    //    }

    //    if (isCooldown1)
    //    {
    //        cooltimeImage1.fillAmount -= 1 / cooldown1 * Time.deltaTime;

    //        if(cooltimeImage1.fillAmount <= 0)
    //        {
    //            cooltimeImage1.fillAmount = 0;
    //            isCooldown1 = false;
    //        }
    //    }
    //}

    //void SLOT2()
    //{
    //    if (Input.GetKey(KeyCode.Alpha2) && isCooldown2 == false)
    //    {
    //        isCooldown2 = true;
    //        cooltimeImage2.fillAmount = 1;
    //    }

    //    if (isCooldown2)
    //    {
    //        cooltimeImage2.fillAmount -= 1 / cooldown2 * Time.deltaTime;

    //        if (cooltimeImage2.fillAmount <= 0)
    //        {
    //            cooltimeImage2.fillAmount = 0;
    //            isCooldown2 = false;
    //        }
    //    }
    //}

    //void SLOT3()
    //{
    //    if (Input.GetKey(KeyCode.Alpha3) && isCooldown3 == false)
    //    {
    //        isCooldown3 = true;
    //        cooltimeImage3.fillAmount = 1;
    //    }

    //    if (isCooldown3)
    //    {
    //        cooltimeImage3.fillAmount -= 1 / cooldown3 * Time.deltaTime;

    //        if (cooltimeImage3.fillAmount <= 0)
    //        {
    //            cooltimeImage3.fillAmount = 0;
    //            isCooldown3 = false;
    //        }
    //    }
    //}

    //void SLOT4()
    //{
    //    if (Input.GetKey(KeyCode.Alpha4) && isCooldown4 == false)
    //    {
    //        isCooldown4 = true;
    //        cooltimeImage4.fillAmount = 1;
    //    }

    //    if (isCooldown4)
    //    {
    //        cooltimeImage4.fillAmount -= 1 / cooldown4 * Time.deltaTime;

    //        if (cooltimeImage4.fillAmount <= 0)
    //        {
    //            cooltimeImage4.fillAmount = 0;
    //            isCooldown4 = false;
    //        }
    //    }
    //}

    //void SLOT5()
    //{
    //    if (Input.GetKey(KeyCode.Alpha5) && isCooldown5 == false)
    //    {
    //        isCooldown5 = true;
    //        cooltimeImage5.fillAmount = 1;
    //    }

    //    if (isCooldown5)
    //    {
    //        cooltimeImage5.fillAmount -= 1 / cooldown5 * Time.deltaTime;

    //        if (cooltimeImage5.fillAmount <= 0)
    //        {
    //            cooltimeImage5.fillAmount = 0;
    //            isCooldown5 = false;
    //        }
    //    }
    //}

    //void SLOT6()
    //{
    //    if (Input.GetKey(KeyCode.Alpha6) && isCooldown6 == false)
    //    {
    //        isCooldown6 = true;
    //        cooltimeImage6.fillAmount = 1;
    //    }

    //    if (isCooldown6)
    //    {
    //        cooltimeImage6.fillAmount -= 1 / cooldown6 * Time.deltaTime;

    //        if (cooltimeImage6.fillAmount <= 0)
    //        {
    //            cooltimeImage6.fillAmount = 0;
    //            isCooldown6 = false;
    //        }
    //    }
    //}

    //void SLOT7()
    //{
    //    if (Input.GetKey(KeyCode.Alpha7) && isCooldown7 == false)
    //    {
    //        isCooldown7 = true;
    //        cooltimeImage7.fillAmount = 1;
    //    }

    //    if (isCooldown7)
    //    {
    //        cooltimeImage7.fillAmount -= 1 / cooldown7 * Time.deltaTime;

    //        if (cooltimeImage7.fillAmount <= 0)
    //        {
    //            cooltimeImage7.fillAmount = 0;
    //            isCooldown7 = false;
    //        }
    //    }
    //}

    //void SLOT8()
    //{
    //    if (Input.GetKey(KeyCode.Alpha8) && isCooldown8 == false)
    //    {
    //        isCooldown8 = true;
    //        cooltimeImage8.fillAmount = 1;
    //    }

    //    if (isCooldown8)
    //    {
    //        cooltimeImage8.fillAmount -= 1 / cooldown8 * Time.deltaTime;

    //        if (cooltimeImage8.fillAmount <= 0)
    //        {
    //            cooltimeImage8.fillAmount = 0;
    //            isCooldown8 = false;
    //        }
    //    }
    //}
}
