using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingdialogues : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    
    private GameObject[] texts;
    private int currentIndex = 0;

    void Start()
    {
        texts = new GameObject[] { text1, text2, text3, text4, text5, text6, text7, text8 };
        ShowText(currentIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            currentIndex++;
            if (currentIndex < texts.Length)
            {
                ShowText(currentIndex);
            }
            else
            {
                QuitGame();
            }
        }
    }

    void ShowText(int index)
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].SetActive(i == index);
        }
    }

    void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
