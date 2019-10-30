using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdControll : MonoBehaviour
{

    public float speed = 1f;
    public float jumpHeight = 10f;

    public Rigidbody2D rb;

    public bool isFinish;

    public GameObject gameOverText;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isFinish)
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (Input.touchCount > 0 || Input.GetButtonDown("Fire1"))
            {
                rb.velocity = new Vector2(0, jumpHeight);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Pipe")
        {
            gameOverText.SetActive(true);
            isFinish = true;
        }
    }
}
