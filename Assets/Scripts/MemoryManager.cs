using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryManager : MonoBehaviour
{
    private static MemoryManager _instance;

    public static MemoryManager Instance {
        get {
            if (_instance == null) {
                GameObject go = new GameObject("MemoryManager");
                go.AddComponent<MemoryManager>();
            }

            return _instance;
        }
    }

    // public MemoryData[] memoryDataList = new MemoryData[24];
    public List<MemoryData> memoryDataList;

    void Awake() {
        _instance = this;
    }

    void Start() {
        // memoryDataList = new List<MemoryData>();
    }

    // Update is called once per frame
    void Update() {
        
    }


}
