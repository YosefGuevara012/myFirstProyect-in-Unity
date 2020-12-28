using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Vector3 cameraOffset = new Vector3(0f, 3.0f, -4.0f);
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // capture the Player transform(position, rotation)

        target = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    private void LateUpdate()
    {

        this.transform.position = target.TransformPoint(cameraOffset);
        this.transform.LookAt(target);

    }
}
