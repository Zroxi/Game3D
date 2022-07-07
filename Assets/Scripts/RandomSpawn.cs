using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn: MonoBehaviour
{
    int itemCount;

    public GameObject[] myObjects;
    
    
    void Update()
    {
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        if (itemCount<20)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25, 25), 1, Random.Range(-25, 25));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}