using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherTest : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("AnotherTest awake");
    }


    private void Start()
    {
        Debug.Log("this will not be visible if disabled");
    }
}
