using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ARModeUIScript : MonoBehaviour
{
    // reference for panels
    public RectTransform pauseARPanel;

    // reference for alpha of pause panel
    public Image pausePanelArAlpha;

    // Start is called before the first frame update
    void Start()
    {
        // sets pause panel alpha value to 0
        pausePanelArAlpha.CrossFadeAlpha(0, 0, false);

    }

    public void PauseARMode()
    {
        pauseARPanel.DOAnchorPos(new Vector2(0, 0), 0.25f);

        pausePanelArAlpha.CrossFadeAlpha(1, 0.75f, false);

    }

    public void ResumeARMode()
    {
        pauseARPanel.DOAnchorPos(new Vector2(-1340, 0), 0.25f);

        pausePanelArAlpha.CrossFadeAlpha(0, 0.75f, false);

    }

}
