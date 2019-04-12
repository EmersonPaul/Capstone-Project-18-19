using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class AboutPanelAnimation : MonoBehaviour
{
    // main menu and about app panel buttons
    public RectTransform aboutAppPanel, aboutDevsPanel, helpPanel, menuButtons, settingsButton;
    public RectTransform ARInfoPanel, settingsElement;

    // reference to alpha of about app panel
    public Image aboutAppPanelAlpha;

    void Start()
    {
        aboutAppPanelAlpha.CrossFadeAlpha(0, 0, false);
    }

    // open about panel
    public void AboutAppButton()
    {
        menuButtons.DOAnchorPos(new Vector2(0, -650), 0.15f); // slides out main menu buttons

        aboutAppPanel.DOAnchorPos(new Vector2(0,0), 0.15f); // slides in about app panel

        Time.timeScale = 0.50f; // slows down time by 50%

        // changes alpha value of panel
        aboutAppPanelAlpha.CrossFadeAlpha(1f, 0.5f, false);
    }

    // close about panel
    public void CloseAboutAppPanel()
    {
        Time.timeScale = 1.0f; //returns time to normal speed
        menuButtons.DOAnchorPos(new Vector2(0,0), 0.30f); //slides in main menu buttons
        aboutAppPanel.DOAnchorPos(new Vector2(-1180,0), 0.30f); // slides out about app panel

        // fades out alpha value to 0
        aboutAppPanelAlpha.CrossFadeAlpha(0, 0.5f, true);
    }

    //makes about dev panel appear
    public void AboutDevelopersPanel()
    {
        aboutDevsPanel.DOAnchorPos(new Vector2(0, 0), 0.15f); // slide in about dev panel
    }

    // closes dev panel
    public void CloseDevelopersPanel()
    {
        aboutDevsPanel.DOAnchorPos(new Vector2(-1500, 0), 0.15f); // slide out aboutdev panel by -1.5k units
    }

    // makes the help panel appear
    public void HelpPanel()
    {
        helpPanel.DOAnchorPos(new Vector2(0, 0), 0.15f); // slide in help

    }

    // Closes the help panel
    public void CloseHelpPanel()
    {
        helpPanel.DOAnchorPos(new Vector2(0, 650), 0.15f); // you get the logic, i dont have to explain
    }

    public void OpenInfoPanel()
    {
        ARInfoPanel.DOAnchorPos(new Vector2(0, 0), 0.15f);
    }

    public void CloseInfoPanel()
    {
        ARInfoPanel.DOAnchorPos(new Vector2(0, 817), 0.15f);
    }

    public void SettingsButtonAccessed()
    {
        // this if-else statement maintains normal set speed of animation on differing time scales
        if(Time.timeScale == 0.5f)
        {
            settingsButton.DOAnchorPos(new Vector2(165, 0), 0.125f);
            settingsElement.DOAnchorPos(new Vector2(-20, 25), 0.125f);
        }
        else
        {
            settingsButton.DOAnchorPos(new Vector2(165, 0), 0.25f);
            settingsElement.DOAnchorPos(new Vector2(-20, 25), 0.25f);
        }

    }

    // settings button accessed counterpart
    public void SettingsButtonMinimized()
    {
        // this if-else does the same shit as its counterpart
        if(Time.timeScale == 0.5f)
        {
            settingsButton.DOAnchorPos(new Vector2(0, 0), 0.125f);
            settingsElement.DOAnchorPos(new Vector2(-20, -265), 0.125f);
        }

        else
        {
            settingsButton.DOAnchorPos(new Vector2(0, 0), 0.25f);
            settingsElement.DOAnchorPos(new Vector2(-20, -265), 0.25f);
        }
    }

}
