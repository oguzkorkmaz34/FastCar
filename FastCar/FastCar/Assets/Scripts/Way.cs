using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
    public GameObject way;
    bool yolYapildi;

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "mainCar" && yolYapildi == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_location, Quaternion.identity);
            yolYapildi = true;
            ScorManager.skor += 10;
            Destroy(this.gameObject, 4f);
        }
    }
}
