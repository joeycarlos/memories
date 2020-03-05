using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryPopup : MonoBehaviour
{
    public float displayTime;

    public Text mName;
    public Text mDescription;
    public Image mImage;

    void Start() {
        Destroy(gameObject, displayTime);
    }

    public void LoadMemoryData(int id) {
        MemoryData mData = MemoryManager.Instance.memoryDataList[id];
        mName.text = "Memory " + (id + 1).ToString() + ": " + mData.name;
        mDescription.text = mData.description;
        // mImage = mData.sprite
    }

}
