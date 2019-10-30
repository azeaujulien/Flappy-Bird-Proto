using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawn : MonoBehaviour
{
    public GameObject pipe;

    public Vector2 lastPipePos;
    public Vector2 nextPipePos;

    GameObject bird;

    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird");
    }

    void Update()
    {
        if ((int)bird.transform.position.x == (int)lastPipePos.x)
        {
            nextPipePos.x = bird.transform.position.x + 6;
            nextPipePos.y = Random.Range(-2.5f, 2.5f);
            Instantiate(pipe, nextPipePos, Quaternion.identity);
            lastPipePos.x = nextPipePos.x - 1.5f;
        }
    }
}
