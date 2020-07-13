using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed * Input.GetAxis("Vertical"));
        rb.AddForce(transform.right * speed * Input.GetAxis("Horizontal"));
    }
}
