using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombscript : MonoBehaviour
{
    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter(Collider other) 
    {
       //
       //Destroy(gameObject);
       //if(other.gameObject.tag == "Player1")
       //{
        //Player1.Health1 = Player1.Health1-50;
        //Destroy(gameObject);
        //}

        if(other.gameObject.tag == "Enemy")
       {
        Destroy(gameObject);
        Instantiate(explosionEffect,transform.position,transform.rotation);
        }
        if(other.gameObject.tag == "Bullet")
       {
        Destroy(gameObject);
        Instantiate(explosionEffect,transform.position,transform.rotation);
        }
    }
}
