using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public Transform pleyerTransform;
    public Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = pleyerTransform.position + offset;
    }
}
