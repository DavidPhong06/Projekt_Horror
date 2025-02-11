using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchButton;

    void Start()
    {
        switchButton.onClick.AddListener(LoadSampleScene);
    }

    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
