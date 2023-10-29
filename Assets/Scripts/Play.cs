using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject Play_Button;
    [SerializeField] GameObject Pause_Button;
    [SerializeField] GameObject Stop_Button;
    public void Play_Button_Button_Click()
    {
        if (isOn) //кнопка нажата
        {
            Pause_Button.SetActive(false);
            //Stop_Button.SetActive(false);
            Play_Button.SetActive(true);
            isOn = false;
        }
        else //кнопка не нажата
        {
            Pause_Button.SetActive(true);
            Stop_Button.SetActive(true);
            Play_Button.SetActive(false);
            isOn = true;
        }
    }
}
