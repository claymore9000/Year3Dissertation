using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SunInfo : XRBaseInteractable
{
    public GameObject infobox;
    private MeshRenderer infoboxMesh;

    // Start is called before the first frame update
    void Start()
    {
        infoboxMesh = infobox.GetComponent<MeshRenderer>();
        infoboxMesh.enabled = false;
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
