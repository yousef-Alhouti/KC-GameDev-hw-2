using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector2.up * movespeed;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector2.up * -movespeed;
        }

    }
}
