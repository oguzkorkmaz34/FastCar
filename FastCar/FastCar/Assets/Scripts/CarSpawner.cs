using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject random_Car;
    bool can_Spawn = true;
    void Start()
    {
        StartCoroutine(Bekle());
    }

    IEnumerator Bekle()
    {
        while (can_Spawn == true)
        {
            Instantiate(random_Car, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        

    }
}
