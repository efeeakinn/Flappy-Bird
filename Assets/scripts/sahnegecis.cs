using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecis : MonoBehaviour
{
    public void sahneDegis(int sahne_id)
    {
        SceneManager.LoadScene(sahne_id);
    }
}
