using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{

    [SerializeField]float spinSpeed = 0.01f;

    // Update is called once per frame
    void Update()
    {

        Vector3 objectTransform = transform.localEulerAngles;

        objectTransform.y += spinSpeed;

        transform.localEulerAngles = objectTransform;
        
    }
}
