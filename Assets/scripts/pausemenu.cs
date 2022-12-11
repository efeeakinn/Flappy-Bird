using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public GameObject pausep;
    void Start()
    {
        pausep.SetActive(false);
    }

    
    void Update()
    {
        
    }
    public void button_come(string menu)
    {
        if(menu=="pause")
        {
            pausep.SetActive(true);
        }
        else if(menu=="tryAgain")
        {
            pausep.SetActive(false);
        }
        else if(menu=="exit")
        {
            Application.Quit();
            Debug.Log("Cikis Yapildi");
        }
    }
}
