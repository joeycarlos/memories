using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedImage : MonoBehaviour
{
    public float lifespan;

    private float moveSpeed;
    private Vector3 moveDirection;

    private Vector3 moveVector;

    // Start is called before the first frame update
    void Start() {
        Destroy(gameObject, lifespan);
        moveSpeed = 0;
        moveDirection = Vector3.zero;
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(moveVector);
    }

    public void Init(float newMoveSpeed, float newX, float newY) {
        moveSpeed = newMoveSpeed;
        moveDirection = new Vector3(newX, newY, 0);
        moveVector = moveDirection.normalized * moveSpeed * Time.deltaTime;
    }
}
