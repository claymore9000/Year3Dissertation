using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlanetInfo : MonoBehaviour {
    public GameObject infobox; 

    protected void OnHoverEntered()
    {
        print("Jupiter Hover Entered");
        infobox.SetActive(true);
    }

    protected void OnHoverExited()
    {
        print("Jupiter Hover Exited");
        infobox.SetActive(false);
    }
}
