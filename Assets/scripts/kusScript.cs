using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class kusScript : MonoBehaviour
{
    public bool isDead;
    public float hiz = 1f;
    public Rigidbody2D rb2D;
    public Text skor_text;
    public float skor;
    public GameObject restartButton;
    AudioSource audioSource;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        skor = 0;
        audioSource=GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * hiz;
        }
        skor_text.text = skor.ToString();
    }
     void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag=="skor")
        {
            skor++;
        }
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="pipe")
        {
            audioSource.Play();
            Time.timeScale = 0;
            restartButton.SetActive(true);
        }
    }
}
