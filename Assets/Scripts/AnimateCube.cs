using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCube : MonoBehaviour
{
    
    public Material m;
    public float value;
    public float speedOfValue;
    public GameObject robot;
    public bool hide;

    void Start()
    {
        m.SetFloat("_slider", value);   
    }

    void FixedUpdate()
    {

        if(!hide)
        {
            if(value > -0.3f)
            {
                value -= speedOfValue;
                m.SetFloat("_slider", value);
            }
            else
            {
                robot.SetActive(true);
                Destroy(gameObject);
            }
        }
        else
        {
            if(value < 1.1f)
            {
                value += speedOfValue;
                m.SetFloat("_slider", value);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    

    
}
