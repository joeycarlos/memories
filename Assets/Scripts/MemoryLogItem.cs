using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MemoryLogItem : MonoBehaviour, ISelectHandler {

    public int id;
    public AudioClip selectAudio;
    private AudioSource audioSource;

    public void Start() {
        Image mImage = GetComponentsInChildren<Image>()[1];

        MemoryData mData = MemoryManager.Instance.memoryDataList[id];
        if (SceneFlowManager.Instance.ThisScene() == 17 || (id < 24 && id < GameManager.Instance.memoriesUnlocked)) {
            mImage.sprite = mData.sprite;
        }
        else {
            mImage.sprite = MemoryManager.Instance.memoryDataList[24].sprite;
        }
        
    }

    public void OnSelect(BaseEventData eventData) {
        // Update featured memory log item
        GameplayUI.Instance.UpdateFeaturedMemory(id);
        if (audioSource == null) audioSource = GetComponentInParent<AudioSource>();
        audioSource.PlayOneShot(selectAudio);
    }
}
