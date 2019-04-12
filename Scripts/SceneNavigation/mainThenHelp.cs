using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mainThenHelp : MonoBehaviour
{
    public void mainToHelp (int toHelpYou)
    {

        SceneManager.LoadScene(toHelpYou);

    }

}
