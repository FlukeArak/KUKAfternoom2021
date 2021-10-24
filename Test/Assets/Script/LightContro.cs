using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightContro : MonoBehaviour
{
    public Light light1;
    public float intensity = 1f;
    private void OnMouseDown()
    {
        //if ( light1.enabled==false )
        //light1.enabled=true;
        //else light1.enabled=false;
        light1.enabled=!light1.enabled;
        light1.intensity = intensity;
        print("Mouse Down");
        
    }
}
