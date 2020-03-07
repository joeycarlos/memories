using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour
{
    public int memoryID;

    void Start() {
        // load data from MemoryManager
        SpriteRenderer iconSr = GetComponentsInChildren<SpriteRenderer>()[1];
        iconSr.sprite = MemoryManager.Instance.memoryDataList[memoryID].sprite;
    }

    void Update() {
        
    }
}
