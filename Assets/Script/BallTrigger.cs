using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
        Debug.Log("Enter trigger, light on");
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(false);
        Debug.Log("Exit trigger, light off");
    }
}