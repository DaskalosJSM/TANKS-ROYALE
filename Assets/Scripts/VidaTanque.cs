using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaTanque : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private puntaje puntaje;
    public GameManager Manager;
    public int impacto = 0;
    public int vida = 0;
    public GameObject explosion;
    public GameObject grande;
    public bool enemy = false;
    ThirdPersonMovement Player1;
    ThirdPersonMovement Player2;

    private bool end = false;

    void Start()
    {
        Player1 = FindObjectOfType<ThirdPersonMovement>();
        Player2 = FindObjectOfType<ThirdPersonMovement>();
    }
    private void Update()
    {

        if (!end && impacto > vida && enemy == false)
        {
            Instantiate(grande, gameObject.transform.position, gameObject.transform.rotation);
            Instantiate(grande, gameObject.transform.position, gameObject.transform.rotation);
            Manager.currentGameState = GameState.gameOver;
            SceneManager.LoadScene("GameOver");
            end = true;
        }
        if (!end && impacto > vida && enemy == true)
        {

            Instantiate(grande, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" && this.gameObject.tag == "Player2")
        {
            impacto++;
            Instantiate(explosion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);
            Player2.Health2 = Player2.Health2 - 9.2f;
        }
        else if (other.gameObject.tag == "Bullet" && this.gameObject.tag == "Player1")
        {
            impacto++;
            Instantiate(explosion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);
            Player1.Health1 = Player1.Health1 - 9.2f;
        }
        else if (other.gameObject.tag == "Bullet" && this.gameObject.tag == "Enemy")
        {
            puntaje.SumarScore(cantidadPuntos);
            impacto++;
            Instantiate(explosion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bomba" && this.gameObject.tag == "Enemy")
        {
            puntaje.SumarScore(cantidadPuntos);
            impacto++;
        }
    }
}
