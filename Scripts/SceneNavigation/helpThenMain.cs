using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class helpThenMain : MonoBehaviour
{
    public void helpToMain(int helpThenMenu)
    {
        SceneManager.LoadScene(helpThenMenu);


    }


}
