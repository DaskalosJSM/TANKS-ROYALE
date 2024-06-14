using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private puntaje puntaje;
    private int contador = 0;
    public GameObject Destroyed;
    public GameObject explosionEffect;
    public GameObject Fire;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Bullet";
        gameObject.tag = "Wall";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 void OnCollisionEnter(Collision other) {
     if(other.gameObject.tag == "Bullet"){contador++;}
        
        if(contador == 3 && other.gameObject.tag == "Bullet")
        {
            Instantiate(explosionEffect,transform.position,transform.rotation);
            Instantiate(Destroyed,gameObject.transform.position ,gameObject.transform.rotation);
            Instantiate(Fire,gameObject.transform.position ,gameObject.transform.rotation);
            Destroy(gameObject);
            puntaje.SumarScore(cantidadPuntos);
        }
}
       
}
