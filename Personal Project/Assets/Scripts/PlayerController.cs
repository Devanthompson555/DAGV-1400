using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public float verticalInput;

    //will need a fall animation for when character walks off screen
    //will need to add collider with enemy objects

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");
     transform.Translate(Vector3.right *horizontalInput *Time.deltaTime *speed);//move left and right.
        
        
        float verticalInput = Input.GetAxis("Vertical");   
        transform.Translate(Vector3.forward *verticalInput *Time.deltaTime *speed);//move up and down
        
    
        
    }
}
