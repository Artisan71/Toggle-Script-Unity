using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectButton : MonoBehaviour
{
    public Material Red;
    public Material Normal;
    public GameObject Object;
    public GameObject Self;
    private bool isToggled;

    void OnTriggerEnter(Collider other)
    {
        if (!isToggled)
        {
            Self.GetComponent<Renderer>().material = Red;
            Object.SetActive(true);
            isToggled = true;
        }
        else
        {
            Self.GetComponent<Renderer>().material = Normal;
            Object.SetActive(false);
            isToggled = false;
        }
    }
}
