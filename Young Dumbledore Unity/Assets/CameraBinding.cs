using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraBinding : MonoBehaviour
{
    public Camera mCamera;
    [SerializeField]
    public GameObject GameObject;
    public Vector3 cameraPosition;
    public Quaternion cameraRotation;

    void LateUpdate()
    {
        var cameraTransform = mCamera.transform;
        cameraPosition = cameraTransform.position;
        cameraRotation = cameraTransform.rotation;
   

        GameObject.transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z);
        GameObject.transform.rotation = cameraRotation;
        GameObject.transform.Translate(new Vector3(0,0, 0.5f));
    }
} 