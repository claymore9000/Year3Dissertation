using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabPlanet : XRGrabInteractable
{
    private GameObject locktarget;
    private Rigidbody planetRigidbody;
    public GameObject infobox;
    private MeshRenderer infoboxMesh;
    public Vector3 rotateVector;

    
    // makes infobox invisible on start
    private void Start()
    {
        planetRigidbody = gameObject.GetComponent<Rigidbody>();
        infoboxMesh = infobox.GetComponent<MeshRenderer>();
        infoboxMesh.enabled = false;
        rotateVector.y = rotateVector.y*0.1f;
    }

    // Every frame, the planet is rotated and positions on the orbit lock
    private void Update()
    {
        if(transform.parent != null && locktarget != null)
        {
            transform.position = locktarget.transform.position;
            transform.Rotate(rotateVector*Time.deltaTime);
        }
    }

    // filters the locktarget to only locks 
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

    // When user ungrabs an object, it checks for a locktarget and locks to it
    protected override void Detach()
    {
        if (locktarget != null)
        {            
            transform.position = locktarget.transform.position;
            planetRigidbody.velocity = Vector3.zero;
            transform.SetParent(locktarget.transform, true);
        }
    }

    protected override void Grab()
    {
        transform.SetParent(null, true);   
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        if (infobox != null){
            infoboxMesh.enabled = true;
        }
    }
    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        if (infobox != null){
            infoboxMesh.enabled = false;
        }
    }
}

