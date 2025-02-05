using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Naèítanie scény

public class SceneChanger2D : MonoBehaviour
{
    private string sceneToLoad = "Basement"; // Názov cie¾ovej scény

    private void OnTriggerEnter2D(Collider2D other) // 2D verzia OnTriggerEnter
    {
        Debug.Log("Nieèo vstúpilo do triggera: " + other.name); // Debug výstup

        if (other.CompareTag("Player")) // Kontrola, èi je to hráè
        {
            Debug.Log("Hráè vstúpil do triggera, naèítavam scénu: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
