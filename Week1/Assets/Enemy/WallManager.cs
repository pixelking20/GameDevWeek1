using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public GameObject wall;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
            SpawnWall();
    }
    
    void SpawnWall()
    {
        timer = 2f;
        Instantiate(wall, new Vector3(this.transform.position.x, Random.Range(-2f, 2f) ,this.transform.position.z), this.transform.rotation);
    }
}
