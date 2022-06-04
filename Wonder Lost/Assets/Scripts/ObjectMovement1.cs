using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement1 : MonoBehaviour
{
    public float speed = 15.0f;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rigidbody.velocity = dir.normalized * -speed;
    }
}
