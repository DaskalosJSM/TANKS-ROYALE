using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera my_camera;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + my_camera.transform.rotation * Vector3.back,
        my_camera.transform.rotation * Vector3.up);
    }
}
