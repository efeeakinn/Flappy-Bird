using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma : MonoBehaviour
{
    public AudioSource ses;
    
    void Start()
    {
        ses=GetComponent<AudioSource>();
    }

   
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="skor")
        {
            ses.Play();
            
        }
    }
}
