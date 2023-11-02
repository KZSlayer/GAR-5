using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator anim;
    public AnimateCube anCu;
    public GameObject music;
    
    public void On()
    {
        anCu.enabled = true;
    }

    public void EndOn()
    {
        music.SetActive(true);
        anim.enabled = false;
    }
}
