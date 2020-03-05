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

    void Awake() {
        _instance = this;
    }

    public void DisplayMemoryPopup() {
        GameObject iMemoryPopup = Instantiate(memoryPopup, transform, false);
    }
}
