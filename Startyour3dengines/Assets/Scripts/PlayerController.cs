using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float turnspeed= 50.0f;
    private float speed = 30.0f;
    private float horizontalInput;
    private float fowardinput;


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
    

        horizontalInput = Input.GetAxis("Horizontal");
        fowardinput = Input.GetAxis("Vertical");
     //move the vehicle foward

        transform.Translate(Vector3.forward * Time.deltaTime *speed * fowardinput);

        //rotates car
        transform.Rotate(Vector3.up, turnspeed * horizontalInput *Time.deltaTime);
        
    


    }
}
