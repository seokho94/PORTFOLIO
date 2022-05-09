using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    [SerializeField] GameObject obj_Status;
    [SerializeField] Scrollbar Scroll_Status;

    bool isOpen_Status;

    // Start is called before the first frame update
    void Start()
    {
        obj_Status.SetActive(false);
        isOpen_Status = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Open_Status();
        }
    }

    public void Open_Status()
    {
        if (isOpen_Status)
        {
            obj_Status.SetActive(false);
            isOpen_Status = false;
        }

        else
        {
            obj_Status.SetActive(true);
            isOpen_Status = true;
        }
    }
}
