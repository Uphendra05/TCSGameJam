using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject prefab;
    public float spawnRate;
    private float timer;


    void Start()
    {
      
    }

    void Update()
    {
        if(timer <= 0)
        {
            for (int i = 0; i < spawnRate; i++)
            {
                GameObject temp = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
                Destroy(temp, 4f);
            }

            timer = 3f;
        }
        else
        {
            timer -= Time.deltaTime;
        }
      


        
    }
}
