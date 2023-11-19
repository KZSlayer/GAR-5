using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private Transform startTransform;
    public Transform endTransform;
    public bool rotationToTarget;
    public float rotationSpeed = 2;
    public bool ZNotRotation;
    
   
    void Update()
    {
        if(rotationToTarget)
        {
            startTransform = gameObject.transform;
            transform.rotation = Quaternion.Slerp(startTransform.rotation, Quaternion.LookRotation(endTransform.position - startTransform.position), rotationSpeed * Time.deltaTime);
        }

        if(ZNotRotation)
        {
            transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
        }
    }
}