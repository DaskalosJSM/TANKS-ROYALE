using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public float delayed = 2f;
    float countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delayed;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
