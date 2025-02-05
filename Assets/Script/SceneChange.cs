using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Na��tanie sc�ny

public class SceneChanger2D : MonoBehaviour
{
    private string sceneToLoad = "Basement"; // N�zov cie�ovej sc�ny

    private void OnTriggerEnter2D(Collider2D other) // 2D verzia OnTriggerEnter
    {
        Debug.Log("Nie�o vst�pilo do triggera: " + other.name); // Debug v�stup

        if (other.CompareTag("Player")) // Kontrola, �i je to hr��
        {
            Debug.Log("Hr�� vst�pil do triggera, na��tavam sc�nu: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
