using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public GameObject laser;
    public int score = 0;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector3(0, 8, 0);
        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(laser, this.transform.position, this.transform.rotation);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
            Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Point")
            score++;
    }
}
