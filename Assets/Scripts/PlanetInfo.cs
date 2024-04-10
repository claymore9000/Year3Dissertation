using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlanetInfo : MonoBehaviour {
    public GameObject infobox; 

    protected void OnHoverEntered()
    {
        infobox.SetActive(true);
    }

    protected void OnHoverExited()
    {
        infobox.SetActive(false);
    }
}
