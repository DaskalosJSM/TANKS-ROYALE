using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bala1 : MonoBehaviour
{
    public int Anmo = 5;
    public float timeToReload;
    public Rigidbody Shell;
    public GameObject explosionEffect;
    public Transform FireStart;
    private Transform nCanon;
    private bool Reload = false;

    void Start()
    {
        nCanon = FireStart.parent;
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
             StartCoroutine(Reloading());
        }
       if(Input.GetButtonDown("Fire1")&& Anmo>0&&!Reload ){
             Shoot();
              StartCoroutine(Smallreloading());
             Anmo--;
             if(Anmo==0){
                StartCoroutine(Reloading());
             }
        }
    }
    public void Shoot()
    {
        Instantiate(Shell, FireStart.position, nCanon.rotation);
        //Instantiate(explosionEffect,FireStart.position, nCanon.rotation);
    }
   private IEnumerator Reloading(){
        yield return new WaitForSeconds(timeToReload);
        Anmo = 5;
        Debug.Log("reloading");
    }
    private IEnumerator Smallreloading(){
        yield return new WaitForSeconds(0.7f);
        Reload = false ;
    }
}
