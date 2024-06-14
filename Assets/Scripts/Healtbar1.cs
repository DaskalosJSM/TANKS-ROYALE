using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healtbar1 : MonoBehaviour
{
    private Image HealthBar;
    //private Color HealthBarColor;
    public float CurrentHealth;
    public float MaxHealt = 100f;
    ThirdPersonMovement Player;
    
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
        //HealthBarColor = GetComponent<Color>();
        Player = FindObjectOfType<ThirdPersonMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = Player.Health2;
        HealthBar.fillAmount = CurrentHealth/MaxHealt;
        //if(CurrentHealth>70){
            //HealthBarColor = new Color(0.2F, 0.3F, 0.4F, 0.5F);
        //}
        //if(CurrentHealth>40){
            //HealthBarColor = new Color("Red");
        //}
    }
}
