using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    [SerializeField] private Image soundOn;
    [SerializeField] private Image soundOff;

    private bool isMuted;


    private void Start()
    {
        if(!PlayerPrefs.HasKey("isMuted"))
        {
            PlayerPrefs.SetInt("isMuted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = isMuted;
    }
    public void OnButtonPress()
    {
        if(!isMuted)
        {
            isMuted = true;
            AudioListener.pause = true;
        }
        else
        {
            isMuted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }
    private void UpdateButtonIcon()
    {
        if (isMuted)
        {
            soundOn.enabled = true;
            soundOff.enabled = false;
        }
        else
        {
            soundOn.enabled = false;
            soundOff.enabled = true;
        }
    }
    private void Load()
    {
        isMuted = PlayerPrefs.GetInt("isMuted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("isMuted",isMuted ? 1 : 0);
    }
   
}
