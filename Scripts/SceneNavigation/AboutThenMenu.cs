using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutThenMenu : MonoBehaviour
{
    public void backToMenu(int fromAboutToMenu)
    {
        SceneManager.LoadScene(fromAboutToMenu);

    }


}
