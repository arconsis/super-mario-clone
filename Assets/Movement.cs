using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 3;
    
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;
        transform.Translate(new Vector2(speed * horizontal * Time.deltaTime, 0));   
    }
}
