using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTab : MonoBehaviour
{
    [SerializeField] public GameObject obj_skilltab;
    [SerializeField] public GameObject obj_skillslot;

    private SkillSlot[] skillslots;
    public static bool isSkilltab;
    public string skill;
    public string skillname;

    void Start()
    {
        obj_skilltab.SetActive(false);
        isSkilltab = false;
        skillslots = obj_skillslot.GetComponentsInChildren<SkillSlot>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if(isSkilltab == false)
            {
                OpenSkilltab();
            }   
            else if (isSkilltab)
            {
                CloseSkilltab();
            }
        }
    }

    private void OpenSkilltab()
    {
        obj_skilltab.SetActive(true);
        isSkilltab = true;
    }

    private void CloseSkilltab()
    {
        obj_skilltab.SetActive(false);
        isSkilltab = false;
    }

    public void AcquireSkill(string skill)
    {
        for (int i = 0; i < skillslots.Length; i++)
        {
            if (skillslots[i] == null)
            {

                return;
            }
        }
        
    }
}
