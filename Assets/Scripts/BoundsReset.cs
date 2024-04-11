using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BoundsReset : MonoBehaviour
{

    private Rigidbody planetRigidbody;
    private void Start()
    {
        planetRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > 5000 | transform.position.y > 5000 | transform.position.z > 5000){
            planetRigidbody.velocity = Vector3.zero;
            planetRigidbody.angularVelocity = Vector3.zero;
            transform.position = Vector3.zero;
        }
        
    } 
}
