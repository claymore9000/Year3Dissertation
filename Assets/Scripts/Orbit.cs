using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject orbitCentre;
    public float speed;
    public bool active = false;
    public string child;

    // Update is called once per frame
    private void Update() 
    {
        if (active && transform.GetChild(0).name == child && orbitCentre != null )
        {
           this.transform.RotateAround(orbitCentre.transform.position, Vector3.up, speed * Time.deltaTime);
        }
    }
}