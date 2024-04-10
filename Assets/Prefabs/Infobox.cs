using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infobox : MonoBehaviour
{
    void OnGUI() 
    {
        GUI.Box(new Rect (0, 0, 0, 0), "Mercury \n Distance from Sun - 57,900,000km \n Diameter - 4,879km");
    }
}
