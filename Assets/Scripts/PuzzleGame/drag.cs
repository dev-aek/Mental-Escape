using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    Camera kamera;
    Vector2 startPozition;

    GameObject[] slotArrays;
    public PuzzleController pC;

    private void OnMouseDrag()
    {
        Vector3 position = kamera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        startPozition = transform.position;

        slotArrays = GameObject.FindGameObjectsWithTag("slot");

    }

    void Update()
    {
       if (Input.GetMouseButtonUp(0))
       {
            //Debug.Log("�nput");
            foreach (GameObject slot in slotArrays)
            {
                if(slot.name == gameObject.name)
                {
                    //Debug.Log("�sim E�le�ti");
                    float mesafe = Vector2.Distance(slot.transform.position, transform.position);
                    
                    if(mesafe <= 1)
                    {
                        //Debug.Log("E�le�ti");
                        
                        transform.position = slot.transform.position;
                        pC.sayi_arttir();
                        this.enabled = false;
                    }
                    else
                    {
                        transform.position = startPozition;
                    }
                }
            }
        }
    }
}
