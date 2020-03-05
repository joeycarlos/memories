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

    public void LoadMemoryData(int id) {
        Debug.Log("LOADING MEMORY " + id);
        MemoryData mData = MemoryManager.Instance.memoryDataList[id];
        Debug.Log(mData.name);
        mName.text = "Memory " + (id + 1).ToString() + ": " + mData.name;
        mDescription.text = mData.description;
        // mImage = mData.sprite
    }

    public void DestroyPopupDelay() {
        Destroy(gameObject, displayTime);
    }

}
