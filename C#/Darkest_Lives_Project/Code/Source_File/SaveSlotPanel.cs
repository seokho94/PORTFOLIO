using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveSlotPanel : MonoBehaviour
{

    Button[] buttons;
    string[] slotName;
    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
        slotName = new string[SaveNLoadManager.Instance.GetMaxSlot()];
    }

    private void OnEnable()
    {
        SettingSlot();
    }

    public void SettingSlot()
    {
        DirectoryInfo[] slotInfo;
        SaveNLoadManager.Instance.GetSaveFileList(out slotInfo);

        for (int i = 0; i < slotInfo.Length; i++)
        {
            slotName[i] = slotInfo[i].Name;
        }
    }

    public void ClickTheButton(int idx)
    {
        if(slotName[idx] == null)
            return;
        SaveNLoadManager.Instance.SetSaveSlot(slotName[idx]);
        //라스트 씬도 저장해놔야되는구만
        LoadingSceneController.Instance.LoadScene("Cave_Map");
    }
}
