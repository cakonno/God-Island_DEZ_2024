using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    public int age;

    void Start()
    {
        if (age <= 10)
        {
            Debug.Log("novo");
        }
        else
        {
            Debug.Log("velho");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
