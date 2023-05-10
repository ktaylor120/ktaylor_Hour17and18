using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    private Animator lampanimator;

    private void Start()
    {
        lampanimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            lampanimator.SetTrigger("ColorChanging");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            lampanimator.SetTrigger("Scaling");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            lampanimator.SetTrigger("Spinning");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            lampanimator.SetTrigger("Hover");
        }
    }
}