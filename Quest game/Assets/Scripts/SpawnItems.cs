using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject key;
    public GameObject spawnPoint;

    void Start()
    {
        Instantiate(key,new Vector3(spawnPoint.transform.position.x,spawnPoint.transform.position.y,spawnPoint.transform.position.z),Quaternion.Euler(0,90,0));
        
    }

    void Update()
    {
        
    }
}
