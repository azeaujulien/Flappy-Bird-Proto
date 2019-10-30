using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCount : MonoBehaviour
{

    public Text scoreText;
    public int score;

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = "Score : " + score;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "scorePass")
        {
            score += 1;
            Destroy(col.gameObject, 2f);
        }
    }
}
