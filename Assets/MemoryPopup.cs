using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPopup : MonoBehaviour
{
    public float displayTime;

    void Start() {
        Destroy(gameObject, displayTime);
    }

}
