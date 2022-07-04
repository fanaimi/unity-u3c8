using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("TestScript awake");    
    }

    private void Start()
    {
        Debug.Log("this will not be visible if disabled");
    }

}
