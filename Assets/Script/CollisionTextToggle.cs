using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTextToggle : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    private int currentTextIndex = 0;
    private GameObject[] texts;

    void Start()
    {
        texts = new GameObject[] { text, text1, text2, text3 };

        foreach (GameObject t in texts)
        {
            if (t != null) t.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("indicator"))
        {
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
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (currentTextIndex < texts.Length - 1)
            {
                if (texts[currentTextIndex] != null) texts[currentTextIndex].SetActive(false);
                currentTextIndex++;
                if (texts[currentTextIndex] != null) texts[currentTextIndex].SetActive(true);
                Debug.Log("text2");
            }
            else
            {
                if (texts[currentTextIndex] != null) texts[currentTextIndex].SetActive(false);
                GameObject indicator = GameObject.FindGameObjectWithTag("indicator");
                if (indicator != null) Destroy(indicator);
            }
        }
    }
}

