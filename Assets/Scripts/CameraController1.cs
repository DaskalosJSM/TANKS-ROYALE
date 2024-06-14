using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
{
    protected Transform Xcam;
    protected Transform Xparent;

    protected Vector3 localRotation;
    protected float CameraDistance = 10f;

    public float MouseSensivility = 4f;
    public float OrbitDampening = 0f;

    void Start() 
    {
        this.Xcam = this.transform;
        this.Xparent = this.transform.parent;
    }

    void Update()
    { 
        if(Input.GetAxis("Mouse X") != 0)
        {
            localRotation.x += Input.GetAxis("Mouse X") * MouseSensivility ;
        }
        Quaternion QT = Quaternion.Euler(0f,localRotation.x,0f);
        this.Xparent.rotation = Quaternion.Lerp(this.Xparent.rotation,QT,Time.deltaTime*OrbitDampening);
    }
}
