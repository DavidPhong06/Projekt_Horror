using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement; // Pre na��tanie sc�ny

public class EndingTrigger : MonoBehaviour
{
    private string sceneToLoad = "EndingScene"; // N�zov sc�ny, ktor� chceme na��ta�

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Skontrolujeme, �i sa dotkol hr��
        {
            // Na��tame nov� sc�nu
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

