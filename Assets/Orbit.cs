using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float orbitSpeed;
    public GameObject centre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.RotateAround(centre.transform.localPosition, Vector3.left, orbitSpeed * Time.deltaTime);

    }
}
