using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour { 

    public GameObject spawnPosition;

    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject newBall = Instantiate(ball);
            newBall.transform.position = spawnPosition.transform.position;
        }
    }

}
