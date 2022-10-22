using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CameraBinding : MonoBehaviour
{
    public Vector3 CameraInOriginSpacePos { get; }
    [SerializeField] public GameObject go;

    private void Update()
    {
        go.transform.position = CameraInOriginSpacePos;
        var transformPosition = go.transform.position;
        transformPosition.z += 10;
    }
}