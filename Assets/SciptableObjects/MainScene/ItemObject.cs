using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour,IInteractable
{
    public ItemData item;

    public string GetInteractPrompt()
    {
        return string.Format("pick up{0},item.displayName");
    }

    public void OnInteract()
    {
        Destroy(gameObject);
    }
}
