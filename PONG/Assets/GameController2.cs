using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * movespeed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.up * -movespeed;
        }
    }
}
