using UnityEngine;

public class Commands : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (GameObject.Find("Cylinder"))
        {
            gameObject.SetActive(false);
        }
    }
}