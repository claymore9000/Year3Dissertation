using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabPlanet : XRGrabInteractable
{
    private GameObject locktarget;
    private Rigidbody planetRigidbody;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lock")
        {
            locktarget = other.gameObject;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        locktarget = null;
    }

    protected override void Detach()
    {
        if (locktarget != null)
        {
            planetRigidbody = this.gameObject.GetComponent<Rigidbody>();
            transform.position = locktarget.transform.position;
            planetRigidbody.velocity = Vector3.zero;
            planetRigidbody.angularVelocity = Vector3.zero;   
            transform.SetParent(locktarget.transform, true);
        }
    }

    protected override void Grab()
    {
        transform.SetParent(null, true);   
    }
}
