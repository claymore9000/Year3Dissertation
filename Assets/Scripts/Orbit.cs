using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject orbitCentre;
    public float speed;
    public bool active = false;

    // Update is called once per frame
    private void Update() 
    {
        if (orbitCentre != null && active)
        {
           this.transform.RotateAround(orbitCentre.transform.position, Vector3.up, speed * Time.deltaTime);
        }
    }
}