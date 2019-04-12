using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ARrModeToMenu : MonoBehaviour
{
    public void ARtoMenu(int ARMtoMain)
    {
        SceneManager.LoadScene(ARMtoMain);
    }
}
