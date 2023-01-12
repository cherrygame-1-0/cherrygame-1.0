using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 CameraOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = targetTransform.position + CameraOffset;
    }
}
