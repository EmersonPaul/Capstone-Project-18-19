using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeToScene(int changeTheScene) 
    {
        SceneManager.LoadScene(changeTheScene);
    }

    public void quitGame()
    {
        Debug.Log("Quitted Game!");
        Application.Quit();
    }
}
