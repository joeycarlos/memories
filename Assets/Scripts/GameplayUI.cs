using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUI : MonoBehaviour
{
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

    private GameObject iMemoryLog;

    void Awake() {
        _instance = this;
    }

    public void DisplayMemoryPopup(int id) {
        GameObject iMemoryPopup = Instantiate(memoryPopup, transform, false);
        iMemoryPopup.GetComponent<MemoryPopup>().LoadMemoryData(id);
        iMemoryPopup.GetComponent<MemoryPopup>().DestroyPopupDelay();
    }

    public void ToggleMemoryLog() {
        if (GameManager.Instance.state == GameManager.GameState.Gameplay) {
            // enable log
            iMemoryLog = Instantiate(memoryLog, transform, false);
            memoryLogPrompt.gameObject.SetActive(false);
        } else if (GameManager.Instance.state == GameManager.GameState.Log) {
            // disable log
            Destroy(iMemoryLog);
            memoryLogPrompt.gameObject.SetActive(true);
        }
    }

    public void UpdateFeaturedMemory(int id) {
        iMemoryLog.GetComponent<MemoryLog>().featuredMemory.LoadMemoryData(id);
    }
}
