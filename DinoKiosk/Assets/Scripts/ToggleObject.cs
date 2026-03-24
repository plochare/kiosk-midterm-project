using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject objectToToggle;

    public void ToggleVisibility()
    {
        if (objectToToggle != null)
        {
            // Toggles the active state (if active, set inactive; if inactive, set active)
            objectToToggle.SetActive(!objectToToggle.activeInHierarchy);
        }
    }
}