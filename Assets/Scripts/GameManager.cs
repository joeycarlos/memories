using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance {
        get {
            if (_instance == null) {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }

            return _instance;
        }
    }

    public enum GameState { Gameplay, Log };
    public GameState state;

    public int memoriesUnlocked;

    void Awake() {
        _instance = this;
        state = GameState.Gameplay;
    }

    void Start() {
        memoriesUnlocked = GameplayData.MemoriesUnlocked;
    }

    void Update() {
        if (state == GameState.Gameplay) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                GameplayUI.Instance.ToggleMemoryLog();
                state = GameState.Log;
            }
        } else if (state == GameState.Log) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                GameplayUI.Instance.ToggleMemoryLog();
                state = GameState.Gameplay;
            }
        }
    }

    public void IncreaseMemoriesUnlocked() {
        memoriesUnlocked++;
        GameplayData.MemoriesUnlocked = memoriesUnlocked;
    }
}
