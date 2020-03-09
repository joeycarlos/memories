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
        MemoryData mData = MemoryManager.Instance.memoryDataList[id];
        if (id < 24) {
            mName.text = mData.name;
            mDescription.text = mData.description;
            mImage.sprite = mData.sprite;
        } else {
            mName.text = mData.name;
            mDescription.text = mData.description;
            mImage.sprite = mData.sprite;
        }
    }

    public void DestroyPopupDelay() {
        Destroy(gameObject, displayTime);
    }

}
