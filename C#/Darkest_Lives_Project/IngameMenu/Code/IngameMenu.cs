using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameMenu : MonoBehaviour
{
    [SerializeField] private Button quit_bt;
    [SerializeField] private Button continue_bt;
    [SerializeField] private Button option_bt;
    [SerializeField] private GameObject obj_IOP;
    [SerializeField] private Button opt_Exit;

    public GameObject obj_ingameoption;
    bool isESC = false;
    public bool igMenuOn = false;
    

    // Start is called before the first frame update
    void Start()
    {
        obj_ingameoption.SetActive(false);
        obj_IOP.SetActive(false);
        IngameMenu_Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isESC == false)
            {
                IngameMenu_Open();
            }
            else
            {   
                IngameMenu_Close();
            }
        }
    }

    public void IngameMenu_Open()
    {
        Time.timeScale = 0;
        obj_ingameoption.SetActive(true);
        isESC = true;
        igMenuOn = true;
    }

    public void IngameMenu_Close()
    {
        Time.timeScale = 1;
        obj_ingameoption.SetActive(false);
        isESC = false;
        igMenuOn = false;
    }

    public void Ingame_Continue()
    {
        IngameMenu_Close();
    }

    public void Ingame_Quit()
    {
        Debug.Log("메인메뉴 씬을 불러옵니다.");
        LoadingSceneController.Instance.LoadScene("MainMenu");
    }

    public void Ingame_Option()
    {
        obj_IOP.SetActive(true);
        obj_ingameoption.SetActive(false);
    }
    public void Ingame_Save()
    {
        Debug.Log("저장을 수행합니다");
        SaveNLoadManager.Instance.SaveData();
    }
    public void Exit_Button()
    {
        obj_IOP.SetActive(false);
        obj_ingameoption.SetActive(true);
    }
}
