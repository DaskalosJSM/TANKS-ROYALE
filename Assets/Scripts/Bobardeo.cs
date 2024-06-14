using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobardeo : MonoBehaviour
{
    public GameObject Bomba;
    public Transform FireStart;
    private Transform nCanon;
    private int carga = 5;
        void Start()
    {
        nCanon = FireStart.parent;
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButtonDown("Jump") && carga > 0){
             
             Bomb();
             carga--;
        }
    }
         public void Bomb()
    {
        Instantiate(Bomba, FireStart.position, nCanon.rotation);
    }
}
