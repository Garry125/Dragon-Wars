using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField]

    public Text ScoreText;

    static int score = 0;
    public GameObject player;
    AudioSource coin;

    void Start()
    {

        coin = GetComponents<AudioSource>()[0];


    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //coin.Play();
           
            score++;
            ScoreText.text = "Scores: " + score;
            Destroy(gameObject);

            

        }


    }
}
