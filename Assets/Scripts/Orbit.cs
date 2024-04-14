using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Orbit : MonoBehaviour
{
    public GameObject orbitCentre;
    private float speed;
    public float orbitTime;
    public float orbitScale;
    public bool active = false;
    public string child;


    private void Start()
    {
        speed = 365/orbitTime * orbitScale;
        //this.transform.RotateAround(orbitCentre.transform.position, Vector3.up, Random.Range(0,360));
    }

    // Update is called once per frame
    private void Update() 
    {
        if (active && transform.childCount != 0 && transform.GetChild(0).name == child && orbitCentre != null )
        {
           this.transform.RotateAround(orbitCentre.transform.position, Vector3.up, speed * Time.deltaTime);
        }
    }

}