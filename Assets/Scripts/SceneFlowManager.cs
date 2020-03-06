using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlowManager : MonoBehaviour
{
    void Awake() {
        switch (SceneManager.GetActiveScene().buildIndex) {
            case 0:
                GameplayData.MemoriesUnlocked = 0;
                break;
        }
    }

    void Update() {
        switch (SceneManager.GetActiveScene().buildIndex) {
            case 0:     // MAIN SPLASH
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 1:     // INSTRUCTIONS
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 2:     // CONTEXT/SETUP
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 3:     // LEVEL 1 SPLASH
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;

            case 5:     // LEVEL 1 COMPLETE
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 6:     // LEVEL 2 SPLASH
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;

            case 8:     // LEVEL 2 COMPLETE
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 9:     // LEVEL 3 SPLASH
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;

            case 11:    // LEVEL 3 COMPLETE
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 12:    // LEVEL 4 SPLASH
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;

            case 14:    // LEVEL 4 COMPLETE
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
            case 15:    // ENDING
                if (Input.GetKeyDown(KeyCode.Space)) NextScene();
                break;
        }
    }

    void NextScene() {
        switch (SceneManager.GetActiveScene().buildIndex) {
            case 0:     // MAIN SPLASH
                SceneManager.LoadScene(1);
                break;
            case 1:     // INSTRUCTIONS
                SceneManager.LoadScene(2);
                break;
            case 2:     // CONTEXT/SETUP
                SceneManager.LoadScene(3);
                break;
            case 3:     // LEVEL 1 SPLASH
                SceneManager.LoadScene(4);
                break;
            case 4:     // LEVEL 1 GAMEPLAY
                SceneManager.LoadScene(5);
                break;
            case 5:     // LEVEL 1 COMPLETE
                SceneManager.LoadScene(6);
                break;
            case 6:     // LEVEL 2 SPLASH
                SceneManager.LoadScene(7);
                break;
            case 7:     // LEVEL 2 GAMEPLAY
                SceneManager.LoadScene(8);
                break;
            case 8:     // LEVEL 2 COMPLETE
                SceneManager.LoadScene(9);
                break;
            case 9:     // LEVEL 3 SPLASH
                SceneManager.LoadScene(10);
                break;
            case 10:    // LEVEL 3 GAMEPLAY
                SceneManager.LoadScene(11);
                break;
            case 11:    // LEVEL 3 COMPLETE
                SceneManager.LoadScene(12);
                break;
            case 12:    // LEVEL 4 SPLASH
                SceneManager.LoadScene(13);
                break;
            case 13:    // LEVEL 4 GAMEPLAY
                SceneManager.LoadScene(14);
                break;
            case 14:    // LEVEL 4 COMPLETE
                SceneManager.LoadScene(15);
                break;
            case 15:    // ENDING
                SceneManager.LoadScene(16);
                break;
        }
    }
}
