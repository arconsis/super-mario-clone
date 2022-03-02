using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private float jump = 5;
    [SerializeField]
    private int jumpCount = 2;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;
        horizontal *= Time.deltaTime;

        gameObject.transform.Translate(new Vector3(horizontal, 0, 0));

        if (jumpCount < 2 && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.P))) {

            jumpCount++;

            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
    }
}
