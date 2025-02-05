using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject text;

    private int currentTextIndex = 0;
    private GameObject[] texts;
    private bool hasCollidedWithIndicator = false;

    void Start()
    {
        texts = new GameObject[] { text };

        foreach (GameObject t in texts)
        {
            if (t != null) t.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("indicator3"))
        {
            hasCollidedWithIndicator = true;

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
                GameObject indicator = GameObject.FindGameObjectWithTag("indicator3");
                if (indicator != null) Destroy(indicator);
            }
        }
    }
}
