using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //destroys objects that colide together
    {
        Destroy(gameObject);
        Destroy(other. gameObject);
    }



}
