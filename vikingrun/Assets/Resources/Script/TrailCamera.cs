//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////let the camera follow the player smoothly////////////////////////////////////////////////
/////////////////////////////////////////////////////let the camera follow the player smoothly////////////////////////////////////////////////
/////////////////////////////////////////////////////let the camera follow the player smoothly////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCamera : MonoBehaviour
{
    public Transform target;
    public float trailDistance = 5.0f;
    public float heightOffset = 3.0f;
    public float cameraDelay = 0.02f;
    public static Vector3 cameraP;
    // Update is called once per frame
    void Update()
    {
        Vector3 followPos = target.position - target.forward * trailDistance;
        cameraP = followPos;
        cameraP.y += 1;
        followPos.y += heightOffset;
        transform.position += (followPos - transform.position) * cameraDelay;
        transform.LookAt(target.transform);
    }
}