using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bala : MonoBehaviour
{
    public int Anmo;
    public float timeToReload;
    public Rigidbody Shell;
    public GameObject explosionEffect;
    public Transform FireStart;
    private Transform nCanon;
    private bool Reload = false;
    [SerializeField]
    public GameObject[] anmoui;
    

    void Start()
    {
        for(int i=0;i<6; i++)
        {
            anmoui[i].gameObject.SetActive(true);
        }
        nCanon = FireStart.parent;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            StartCoroutine(Reloading());
        }
        if (Input.GetButtonDown("Fire1") && Anmo > 0 && !Reload)
        {
            Shoot();
            StartCoroutine(Smallreloading());
            if (Anmo == 0)
            {
                StartCoroutine(Reloading());
            }
        }
    }
    public void Shoot()
    {
        Instantiate(Shell, FireStart.position, nCanon.rotation);
        anmoui[Anmo].gameObject.SetActive(false);
        Anmo--;
        //Instantiate(explosionEffect,FireStart.position, nCanon.rotation);
    }
    private IEnumerator Reloading()
    {
        yield return new WaitForSeconds(timeToReload);
        Anmo = 5;
        for(int i=0;i<6; i++)
        {
            anmoui[i].gameObject.SetActive(true);
        }
        Debug.Log("reloading");
    }
    private IEnumerator Smallreloading()
    {
        yield return new WaitForSeconds(0.7f);
        Reload = false;
    }

}
