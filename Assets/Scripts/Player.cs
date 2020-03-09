﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public GameObject memoryCollectEffect;
    public ParticleSystem smoke;

    private float horizontalMovement;

    // Start is called before the first frame update
    void Start() {
        smoke = GetComponentInChildren<ParticleSystem>();
        smoke.Stop();
    }

    // Update is called once per frame
    void Update() {
        if (GameManager.Instance.state == GameManager.GameState.Gameplay) {
            ReadInput();
            if (horizontalMovement != 0) {
                Move();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) smoke.Play();
            else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)) smoke.Stop();
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
            GameManager.Instance.IncreaseMemoriesUnlocked();
            int id = collision.gameObject.GetComponent<Memory>().memoryID;
            GameplayUI.Instance.DisplayMemoryPopup(id);
            Destroy(collision.gameObject);
            GameObject iMemoryCollectEffect = Instantiate(memoryCollectEffect, collision.transform.position, Quaternion.identity);
            Destroy(iMemoryCollectEffect, 0.9f);
        } else if (collision.gameObject.layer == LayerMask.NameToLayer("Exit")) {
            SceneFlowManager.Instance.NextScene();
        }
    }
}
