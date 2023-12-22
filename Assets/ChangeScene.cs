using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("melih");
    }
    public void changeScene2()
    {
        SceneManager.LoadScene("bitis");
    }
    public void changeScene3()
    {
        SceneManager.LoadScene("last");
    }
}
