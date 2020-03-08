using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MemoryLog : MonoBehaviour
{
    public MemoryPopup featuredMemory;
    public Text returnToGamePrompt;

    // Start is called before the first frame update
    void Start() {
        if (SceneFlowManager.Instance.ThisScene() == 17)
            returnToGamePrompt.gameObject.SetActive(false);

        featuredMemory = transform.Find("MemoryPopup").GetComponent<MemoryPopup>();
        EventSystem.current.SetSelectedGameObject(GameObject.Find("MemoryLogItem"));
    }
}
