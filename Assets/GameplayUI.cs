using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Awake() {
        _instance = this;
    }
}
