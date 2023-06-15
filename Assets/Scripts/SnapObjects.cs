using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObjects : MonoBehaviour 
{ 

    public Transform snapPosition;
    public Transform targetObject;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == targetObject)
        {
            // Calculate the offset between the snap positions
            offset = snapPosition.position - targetObject.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == targetObject)
        {
            // Reset the offset when the objects are no longer in proximity
            offset = Vector3.zero;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Snap the objects together
            targetObject.position = snapPosition.position - offset;
            targetObject.rotation = snapPosition.rotation;
        }
    }

}
