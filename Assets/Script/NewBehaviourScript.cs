using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    public GameObject text2;

    private int currentTextIndex = 0;
    private GameObject[] texts;
    private bool hasCollidedWithIndicator = false;
    private string sceneToLoad = "EndingScene 1";
    void Start()
    {
        texts = new GameObject[] { text, text1, text2 };
        foreach (GameObject t in texts)
        {
            if (t != null) t.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("koliy");
        if (collision.gameObject.CompareTag("indicator2"))
        {
            hasCollidedWithIndicator = true;
            Debug.Log("koliy");

            bool anyTextActive = false;
            foreach (GameObject t in texts)
            {
                if (t != null && t.activeSelf)
                {
                    anyTextActive = true;
                    break;
                }
            }

            if (!anyTextActive && texts[0] != null)
            {
                texts[0].SetActive(true);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && hasCollidedWithIndicator)
        {
            if (currentTextIndex < texts.Length - 1)
            {
                if (texts[currentTextIndex] != null) texts[currentTextIndex].SetActive(false);
                currentTextIndex++;
                if (texts[currentTextIndex] != null) texts[currentTextIndex].SetActive(true);
            }
            else
            {
                if (texts[currentTextIndex] != null) texts[currentTextIndex].SetActive(false);
                GameObject indicator = GameObject.FindGameObjectWithTag("indicator2");

                SceneManager.LoadScene(sceneToLoad);
                if (indicator != null) Destroy(indicator);
            }
        }
    }
}
