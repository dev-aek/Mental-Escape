using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDialogue : MonoBehaviour
{
    public GameObject text;
    public GameObject panel;
    private int i = 1;
    private bool panelIsActive = false;
    private bool isExit = false;
    public DialogTrigger dialogueTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(true);
        i = 0;
        isExit = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        text.SetActive(false);
        panel.SetActive(false);
        i = 1;
        isExit = true;

    }
    private void Update()
    {
        if (isExit.Equals(false))
        {
            if (Input.GetKeyDown(KeyCode.E) && i == 0)
            {
                dialogueTrigger.TriggerDialogue();
                panel.SetActive(true);
                panelIsActive = true;
                i = 1;
            }
            else if (Input.GetKeyDown(KeyCode.E) && panelIsActive == true)
            {
                panel.SetActive(false);
                i = 0;
            }
        }
    }
}

