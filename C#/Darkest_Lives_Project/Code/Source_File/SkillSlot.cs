using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour
{
    [SerializeField] private GameObject Skill_Image;
    [SerializeField] private Text Skill_Name;
    [SerializeField] private Text Skill_explanatory;
    [SerializeField] private Text Request_Mana;

    public static string Image;
    public static string Name;
    public static string explanatory;
    public static string mana;

    public void AddSkill(string skill)
    {

    }

    public void SetColor(float _alpha)
    {

    }
}
