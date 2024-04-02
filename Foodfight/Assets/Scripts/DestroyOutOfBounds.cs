using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -13;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) //destroys the food when it goes off screen
        {
            Destroy(gameObject);

        } else if (transform.position.z <lowerBound) //destroys animals that go off screen
        {
            Debug.Log("Game Over!"); //if object goes past player give gameover.
            Destroy(gameObject);
        }

    }
}
