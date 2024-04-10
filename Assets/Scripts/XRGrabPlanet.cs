using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabPlanet : XRGrabInteractable
{
    
    private bool locked = false;
    private GameObject locktarget;
    private Rigidbody planetRigidbody;


    private void OnTriggerEnter(Collider other)
    {
        locktarget = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        locktarget = null;
    }

    protected override void Detach()
    {
        if (locktarget != null && locktarget.tag == "Lock")
        {
            planetRigidbody = this.gameObject.GetComponent<Rigidbody>();
            planetRigidbody.velocity = Vector3.zero;
            planetRigidbody.angularVelocity = Vector3.zero;
            transform.parent = locktarget.transform;
        }
    }
}
