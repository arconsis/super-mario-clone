using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis("Vertical") * speed;
        var horizontal = Input.GetAxis("Horizontal") * speed;
        vertical *= Time.deltaTime;
        horizontal *= Time.deltaTime;

        gameObject.transform.Translate(new Vector3(horizontal, vertical, 0));
    }
}
