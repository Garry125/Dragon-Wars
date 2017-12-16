using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {
    [SerializeField]

    public Text ScoreText;

    static int score = 0;
    public GameObject player;
    AudioSource mcoinsSound;

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        mcoinsSound = GetComponents<AudioSource>()[0];


    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            
          
            score++;
            ScoreText.text = "Scores: " + score;
            
            mcoinsSound.Play();
            Destroy(gameObject);


        }


    }
}
