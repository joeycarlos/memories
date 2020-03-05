using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public float speed = 2.0f;
    public Vector3 offsetVector;

    void Start() {
        transform.position = target.transform.position + offsetVector;
    }

    void LateUpdate() {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = transform.position;
        position.x = Mathf.Lerp(transform.position.x, target.transform.position.x + offsetVector.x, interpolation);
        position.y = Mathf.Lerp(transform.position.y, target.transform.position.y + offsetVector.y, interpolation);
        position.z = offsetVector.z;

        transform.position = position;
    }
}
