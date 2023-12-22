using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public GameObject panel;
    int yerlesstirilen_parca = 0;
    int toplam_puzzle = 9;
    public void sayi_arttir()
    {
        yerlesstirilen_parca++;
        if(yerlesstirilen_parca == toplam_puzzle)
        {
            panel.SetActive(true);
        }
    }
}
