﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    private float horizontalMovement;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (GameManager.Instance.state == GameManager.GameState.Gameplay) {
            ReadInput();
            if (horizontalMovement != 0) Move();
        }
    }

    void ReadInput() {
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
    }

    void Move() {
        Vector3 moveVector = new Vector3(horizontalMovement * Time.deltaTime, 0, 0);
        transform.Translate(moveVector);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Memory")) {
            // Debug.Log(MemoryManager.Instance.memoryDataList[collision.gameObject.GetComponent<Memory>().memoryID].name);
            int id = collision.gameObject.GetComponent<Memory>().memoryID;
            GameplayUI.Instance.DisplayMemoryPopup(id);
            Destroy(collision.gameObject);
        }
    }
}
