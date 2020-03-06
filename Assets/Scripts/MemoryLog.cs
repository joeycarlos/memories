using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MemoryLog : MonoBehaviour
{
    public MemoryPopup featuredMemory;

    // Start is called before the first frame update
    void Start() {
        featuredMemory = transform.Find("MemoryPopup").GetComponent<MemoryPopup>();
        EventSystem.current.SetSelectedGameObject(GameObject.Find("MemoryLogItem"));
    }
}
