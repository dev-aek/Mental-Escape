using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void OpenCredits()
    {
        panel.SetActive(true);
    }

    public void CloseCredits()
    {
        panel.SetActive(false);
    }
}
