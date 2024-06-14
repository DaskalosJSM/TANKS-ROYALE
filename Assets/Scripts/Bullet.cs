using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Lifetime = 8f;
    float coutdown;
    public float speed = 20f;
    public Rigidbody rb ;


    // Start is called before the first frame update
    void Start()
    {
        coutdown = Lifetime;
        rb.velocity = speed * transform.forward; 
    }

    void Update() {
    coutdown -= Time.deltaTime; 
    if(coutdown <= 0f)
    {
        Destroy(gameObject);
    }   
    }
    void OnCollisionEnter(Collision collision) 
    {
        // Obtener la normal de la superficie de colisión
        Vector3 normal = collision.contacts[0].normal;

        // Calcular la dirección reflejada
        Vector3 reflectDir = Vector3.Reflect(rb.velocity.normalized, normal);

        // Ajustar la velocidad del proyectil
        rb.velocity = reflectDir * speed;

        // Ajustar la rotación del proyectil para que mire en la dirección del nuevo vector
        Quaternion targetRotation = Quaternion.LookRotation(reflectDir);
        rb.rotation = targetRotation;
    }
}
