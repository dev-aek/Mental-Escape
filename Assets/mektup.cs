using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mektup : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    private int i = 0;
    private bool panelIsActive = false;
    private bool isExit = false;

    public GameObject text;
    public AudioSource audioKlip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(true);
        i = 0;
        isExit = false;


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        text.SetActive(false);
        panel2.SetActive(false);
        i = 1;
        isExit = true;

    }
    private void Update()
    {
        if (isExit.Equals(false))
        {
            if (Input.GetKeyDown(KeyCode.E) && i == 0)
            {
                panel.SetActive(true);
                panel2.SetActive(true);
                panelIsActive = true;
                i = 1;
                audioKlip.Play();
            }
            else if (Input.GetKeyDown(KeyCode.E) && panelIsActive == true)
            {
                panel2.SetActive(false);
                i = 0;
            }
        }
    }
}
