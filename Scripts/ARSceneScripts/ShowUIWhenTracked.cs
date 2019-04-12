using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Vuforia;
using DG.Tweening;

public class ShowUIWhenTracked : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    public RectTransform SpecificationsPanel, ARPanel;

    public GameObject ShowSpecsPanelButton, HideSpecsPanelButton, PauseButton, ResumeButton;

    public RectTransform SpecificationsTextMesh;


    bool specsPanelDisplayed = false;

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }

            SpecificationsTextMesh.gameObject.SetActive(false);

        }

        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED)
            {
                SpecificationsTextMesh.gameObject.SetActive(true);

                SpecificationsPanel.DOAnchorPos(new Vector2(-25,-40), 0.25f, false); // slide in specs

                ARPanel.DOAnchorPos(new Vector2(-320, 0), 0.25f, false); // slide in buttons

                SpecificationsTextMesh.DOAnchorPos(new Vector2(-15, 50), 0.30f, false); // slide in specs text - TEXTMESH SPECS

                specsPanelDisplayed = true;

                HideSpecsPanelButton.gameObject.SetActive(true);

                ShowSpecsPanelButton.gameObject.SetActive(false);

            }

            else
            {
                SpecificationsPanel.DOAnchorPos(new Vector2(500, -40),0.125f, false); // slide out specs panel

                ARPanel.DOAnchorPos(new Vector2(-320, -150), 0.125f, false); // slide out panel

                SpecificationsTextMesh.DOAnchorPos(new Vector2(-15, -485), 0.125f, false); // slide out text - TEXTMESH SPECS

                specsPanelDisplayed = false;

                HideSpecsPanelButton.gameObject.SetActive(true);

                ShowSpecsPanelButton.gameObject.SetActive(false);

                SpecificationsTextMesh.gameObject.SetActive(false);

            }  

        }

        public void PauseWhileTargetFound()
        {
            if(specsPanelDisplayed == true)
            {
                ARPanel.DOAnchorPos(new Vector2(-320, -150), 0.125f, false);

                SpecificationsPanel.DOAnchorPos(new Vector2(500, -40), 0.25f, false);   

            }

        }

        public void ResumeWhileTargetFound()
        {
            if(specsPanelDisplayed == true)
            {
                ARPanel.DOAnchorPos(new Vector2(-320, 0), 0.25f, false);

                SpecificationsPanel.DOAnchorPos(new Vector2(-25, -40), 0.25f, false);

            }

        }


        // for hiding and displaying specifications panel upon click of button in AR Buttons panel
        public void HideSpecsPanel()
        {
            SpecificationsPanel.DOAnchorPos(new Vector2(500, -40), 0.25f, false);

            HideSpecsPanelButton.gameObject.SetActive(false);

            ShowSpecsPanelButton.gameObject.SetActive(true);
            
        }

        public void ShowSpecsPanel()
        {
            SpecificationsPanel.DOAnchorPos(new Vector2(-25, -40), 0.25f, false);

            HideSpecsPanelButton.gameObject.SetActive(true);

            ShowSpecsPanelButton.gameObject.SetActive(false);

        }

        
}
