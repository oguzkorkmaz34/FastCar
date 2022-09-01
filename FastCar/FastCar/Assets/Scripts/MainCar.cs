using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    public float dikeyhiz, yatayHiz, varsayilanHiz;
    private float dikeyHareket, yatayHareket;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        dikeyHareket = Input.GetAxis("Vertical");
        yatayHareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatayHareket * 50 * yatayHiz * Time.deltaTime, varsayilanHiz + dikeyHareket * 50 * dikeyhiz * Time.deltaTime);
        if (transform.position.x > 1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y);
            transform.position = right_limit;   
        }
        if (transform.position.x < -1.82f)
        {
            Vector3 left_limit = new Vector3(-1.82f, transform.position.y);
            transform.position = left_limit;
        }

    }
}

