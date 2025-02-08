using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class happyending : MonoBehaviour
{
    private string sceneToLoad = "EndingScene";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("koliy");
        if (collision.gameObject.CompareTag("indicator4"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
