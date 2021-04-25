using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class click_on_it : MonoBehaviour
{
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
    }
}