using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnSpeed = 1;
    public float timer = 0;
    public GameObject pipe;
    public float maxYukseklik;
    public float minYukseklik;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-maxYukseklik, maxYukseklik), 0);
    }

    
    void Update()
    {
        if(timer > spawnSpeed)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-maxYukseklik, maxYukseklik), 0);
            Destroy(newpipe, 14);
            timer = 0;
        }
            timer +=Time.deltaTime;
    }

   
}
