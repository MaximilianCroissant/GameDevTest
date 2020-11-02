using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public GameObject ball;

    //public GameObject deathWall;



    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "DeathWall") {

            Destroy(gameObject);

        }

    }

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
