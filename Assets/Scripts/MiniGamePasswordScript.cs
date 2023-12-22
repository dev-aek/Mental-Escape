using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePasswordScript : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    [SerializeField] GameObject[] myObjects;
    [SerializeField] GameObject pamTextPanel;
    int i;
    [SerializeField] GameObject FinishPanel;



    void Start()
    {
        i = 0;
    }

    private void OnEnable()
    {
        i = 0;
        for(int i = 0; i <myObjects.Length; i++)
        {
            myObjects[i].transform.SetSiblingIndex(Random.Range(0, 9));
        }
    }

    public void ButtonOrder(int button)
    {

        //1953
        Debug.Log("Pressed");
        if (button == 1 && i==0)
        {
            i++;
            Debug.Log("Next Button" + i);
        }
        else if(button == 9 && i==1)
        {
            i++;
            Debug.Log("Next Button" + i);
        }
        else if (button == 8 && i==2)
        {
            i++;
            Debug.Log("Next Button" + i);
        }
        else if (button == 5 && i==3)
        {
            pamTextPanel.SetActive(true);
            i = 0;
            ButtonOrderPanelClose();
            ActiveToEnd();
        }
        else
        {
            Debug.Log("Failed");
            OnEnable();
            Debug.Log("Next Button" + i);

        }
        /*  if(button == 9)
          {
              Debug.Log("Pass");
              nextButton = 0;
              ButtonOrderPanelClose();
          }*/
    }

    public void ButtonOrderPanelClose()
    {
        GamePanel.SetActive(false);;
    }

    public void ButtonOrderPanelOpen()
    {
        GamePanel.SetActive(true);
    }
    public void ActiveToEnd()
    {
        FinishPanel.SetActive(true);
    }

    void Update()
    {
        
    }
}
