using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_2 : MonoBehaviour
{
    bool isOn = false;
    bool isSpop = false;
    [SerializeField] GameObject Play_Button;
    [SerializeField] GameObject Pause_Button;
    public void Play_Button_Click()
    {
        if (isOn && isSpop == false) //кнопка нажата
        {
            Pause_Button.SetActive(false);
            Play_Button.SetActive(true);
            isOn = false;
        }
        else //кнопка не нажата
        {
            Pause_Button.SetActive(true);
            Play_Button.SetActive(false);
            isOn = true;
            isSpop = false;
        }
    }
    public void Stop_Button_Click()
    {
        Pause_Button.SetActive(false);
        Play_Button.SetActive(true);
        isSpop = true;
    }
}
