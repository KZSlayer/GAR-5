using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject Infomation_Panel;
    public void Info_Button_Click()
    {
        if (isOn)
        {
            Infomation_Panel.SetActive(false);
            isOn = false;
        }
        else
        {
            Infomation_Panel.SetActive(true);
            isOn = true;
        }
    }
}
