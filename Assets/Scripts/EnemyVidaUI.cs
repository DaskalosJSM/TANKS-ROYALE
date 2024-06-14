using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVidaUI : MonoBehaviour
{
    SpriteRenderer Spritecolor;
    public GameObject healthbar;
    public float daño = 0;
    Color verde;
    Color amarillo;
    Color rojo;

    void Start()
    {
        Spritecolor = healthbar.GetComponent<SpriteRenderer>();
        verde = Color.green;
        amarillo = Color.yellow;
        rojo = Color.red;
        Spritecolor.color = verde;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Bullet" && this.gameObject.tag == "Enemy")
        {
            Inpact();
            Spritecolor.color = amarillo;
            if (daño <= 0.98) Spritecolor.color = rojo;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bomba" && this.gameObject.tag == "Enemy")
        {
            Inpact();
            Spritecolor.color = amarillo;
            if (daño <= 0.98) Spritecolor.color = rojo;
        }
    }
    void Inpact()
    {
        healthbar.transform.localScale = new Vector3(daño, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
        daño = daño - 0.98f;
    }
}
