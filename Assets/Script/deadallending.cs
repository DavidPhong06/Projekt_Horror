using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadallending : MonoBehaviour
{
    private string sceneToLoad = "EndingScene 1";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("koliy");
        if (collision.gameObject.CompareTag("indicator6"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}