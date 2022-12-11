using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public bool oyunDurdumu = false;
    public void oyunDur()
    {
        if (oyunDurdumu == false)
        {
        Time.timeScale = 0f;
        oyunDurdumu = true;

        }
        else
        {
            Time.timeScale = 1f;
            oyunDurdumu = false;
        }
    }
   
    


}
