using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement; // Pre naèítanie scény

public class EndingTrigger : MonoBehaviour
{
    private string sceneToLoad = "EndingScene"; // Názov scény, ktorú chceme naèíta

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Skontrolujeme, èi sa dotkol hráè
        {
            // Naèítame novú scénu
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

