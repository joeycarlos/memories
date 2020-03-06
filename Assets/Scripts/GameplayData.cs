using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameplayData
{
    private static int memoriesUnlocked;

    public static int MemoriesUnlocked {
        get {
            return memoriesUnlocked;
        }
        set {
            memoriesUnlocked = value;
        }
    }
}
