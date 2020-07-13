using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 10f;
    }

    // Update is called once per frame
    void Update()
    {
         transform.position -= new Vector3(0.1f, 0 , 0);
         timer -= Time.deltaTime;
         if(timer <= 0f)
            Destroy(this.gameObject);
    }
}
