using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class mainToAR : MonoBehaviour
{
    public GameObject loadingScreen; // reference to loading screen panel

    public Slider loadingScreenSlider; // reference to loading slider

    public RectTransform quitApplicationPanel;

    public Image quitAppPanelAlpha;


    void Start() => quitAppPanelAlpha.CrossFadeAlpha(0, 0, false);

    public void QuitApplicationPanelActive()
    {
        quitApplicationPanel.DOAnchorPos(new Vector2(0,0), 0.25f);

        quitAppPanelAlpha.CrossFadeAlpha(1, 0.75f, false);
    }

    public void QuitApplicationNo()
    {
        quitApplicationPanel.DOAnchorPos(new Vector2(0, 750), 0.25f);

        quitAppPanelAlpha.CrossFadeAlpha(0, 0.15f, false);
    }


    // end of quit button panel codes

    // scene navigation codes start
    public void ToNavigate(int toSceneIndex)
    {
        StartCoroutine(LoadSceneAsynchronously(toSceneIndex));
    }

    IEnumerator LoadSceneAsynchronously (int toSceneIndex)
    {
        AsyncOperation sceneOperation = SceneManager.LoadSceneAsync(toSceneIndex);

        loadingScreen.SetActive(true);

        while(!sceneOperation.isDone)
        {
            float loadingProgress = Mathf.Clamp01(sceneOperation.progress / 0.9f);

            loadingScreenSlider.value = loadingProgress;

            yield return null;
        }

    }


    //start of quit app code
    public void QuitAppYes()
    {
        Debug.Log("Application has quit!");
        Application.Quit();
    }
    // end of scene navigation codes
}
