using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MemoryLogItem : MonoBehaviour, ISelectHandler {

    public int id;

    public void OnSelect(BaseEventData eventData) {
        // Update featured memory log item
        GameplayUI.Instance.UpdateFeaturedMemory(id);
    }
}
