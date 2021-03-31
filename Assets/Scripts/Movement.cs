using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public float speed = 5f;
    public float currentSpeed = 1f;
    float targetSpeed = -30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSpeed < targetSpeed)
        {
            currentSpeed += Time.deltaTime;
        }
        transform.position = transform.position + new Vector3( -currentSpeed* Time.deltaTime*1.5f,  0, 0);
        //Debug.Log(transform.position);
    }
    
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.tag == "trash")
    //     {
    //         
    //     }
    // }
    

}
