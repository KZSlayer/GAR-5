using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationChange : MonoBehaviour
{
    public int f;
    public Animator anim;
    void Start()
    {
        f = RandomFloat();
        anim.SetInteger("change_animator",f);
    }

    private int RandomFloat()
    {
        int r;
        r = Random.Range(1,3);
        return r;
    }
}
