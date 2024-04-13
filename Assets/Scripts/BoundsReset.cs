using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BoundsReset : MonoBehaviour
{

    private Rigidbody planetRigidbody;
    public GameObject mylock;

    private void Start()
    {
        planetRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(mylock.transform.position, transform.position) > 3000){

            if (mylock.transform.childCount == 0)
            {
                planetRigidbody.velocity = Vector3.zero;
                planetRigidbody.angularVelocity = Vector3.zero;
                transform.position = mylock.transform.position;
            }
            else {
                planetRigidbody.velocity = Vector3.zero;
                planetRigidbody.angularVelocity = Vector3.zero;
                transform.position = new Vector3(0, 200, 0);
            }

        }
        
    } 
}
