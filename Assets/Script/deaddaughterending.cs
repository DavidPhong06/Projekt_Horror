using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deaddaughterending : MonoBehaviour
{
    private string sceneToLoad = "EndingScene 2";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("indicator5"))
        {
            if (NewBehaviourScript.Instance.textfin == 1)
            {
                Debug.Log("koliy");
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.Log("nn");
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
