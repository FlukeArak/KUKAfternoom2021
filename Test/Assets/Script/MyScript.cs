using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string myName ="Arak";
    void Start()
    {
        print("Hello "+ myName);
    }
    private void Awake()
    {
        print("Awake");
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello Update");
    }
}
