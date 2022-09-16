using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionManager : MonoBehaviour
{
    public void StartGame ()
    {
        Debug.Log("Start Game");
        // pwede man string ipasa nyo - name kang scene
        SceneManager.LoadScene("Playground");
        // or pwedeng int ang ipasa nyo - kung pang pira sa build settings scene [starts from 0]
        //SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
