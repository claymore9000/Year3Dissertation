using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
    public float mult;
    public GameObject target;
    public GameObject planet;

    // Update is called once per frame
    void Update()
    {
        
        if (target!=null){
            this.gameObject.transform.LookAt(target.transform);
        }

        if (planet != null){
            transform.position = planet.transform.position + new Vector3(0,planet.transform.localScale.y * 1.3f, 0);
        }
    }
}
