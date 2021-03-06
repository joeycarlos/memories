﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUI : MonoBehaviour {
    private static GameplayUI _instance;

    public static GameplayUI Instance {
        get {
            if (_instance == null) {
                GameObject go = new GameObject("GameplayUI");
                go.AddComponent<GameplayUI>();
            }

            return _instance;
        }
    }

    public GameObject memoryPopup;
    public GameObject memoryLog;
    public Text memoryLogPrompt;
    public Text controlPrompt;

    private GameObject iMemoryLog;
    private GameObject iMemoryPopup;

    public AudioClip openLogSound;

    private AudioSource audioSource;

    void Awake() {
        _instance = this;
    }

    void Start() {
        if (SceneFlowManager.Instance.ThisScene() == 17) {
            memoryLogPrompt.gameObject.SetActive(false);
            controlPrompt.gameObject.SetActive(false);
        }
        audioSource = GetComponent<AudioSource>();
    }

    public void DisplayMemoryPopup(int id) {
        if (iMemoryPopup != null)
            Destroy(iMemoryPopup);

        iMemoryPopup = Instantiate(memoryPopup, transform, false);
        iMemoryPopup.GetComponent<MemoryPopup>().LoadMemoryData(id);
        iMemoryPopup.GetComponent<MemoryPopup>().DestroyPopupDelay();
    }

    public void ToggleMemoryLog() {
        if (GameManager.Instance.state == GameManager.GameState.Gameplay) {
            // enable log
            iMemoryLog = Instantiate(memoryLog, transform, false);
            memoryLogPrompt.gameObject.SetActive(false);
            controlPrompt.gameObject.SetActive(false);
            audioSource.PlayOneShot(openLogSound);
        } else if (GameManager.Instance.state == GameManager.GameState.Log) {
            // disable log
            Destroy(iMemoryLog);
            memoryLogPrompt.gameObject.SetActive(true);
            controlPrompt.gameObject.SetActive(true);
        }
    }

    public void UpdateFeaturedMemory(int id) {
        if (SceneFlowManager.Instance.ThisScene() == 17) {
            iMemoryLog = GameObject.Find("MemoryLog");
        }

        if (id < GameManager.Instance.memoriesUnlocked || SceneFlowManager.Instance.ThisScene() == 17)
            iMemoryLog.GetComponent<MemoryLog>().featuredMemory.LoadMemoryData(id);
        else
            iMemoryLog.GetComponent<MemoryLog>().featuredMemory.LoadMemoryData(24); // load the default unknown memory
    }
}
