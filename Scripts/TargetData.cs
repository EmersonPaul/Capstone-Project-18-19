using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    public class TargetData : MonoBehaviour
    {
        public Transform aircraftSpecs;

        // function called once per frame
        void Update()
        {
            StateManager managedState = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> trackedBehaviours = managedState.GetActiveTrackableBehaviours();

            foreach(TrackableBehaviour behaviourTracked in trackedBehaviours)
            {
                string name = behaviourTracked.TrackableName;
                ImageTarget targetImage = behaviourTracked as ImageTarget;
                Vector2 size = targetImage.GetSize();

                Debug.Log("Active image target" + name + "size" + size.x + ", " + size.y);


                //the infos

                if (name == "R38ClassA")
                {
                    aircraftSpecs.GetComponent<Text>().text = "This is the r38 a class airship";
                }

                else if (name == "Lak2Genesis")
                {
                    aircraftSpecs.GetComponent<Text>().text = "This is the lak2 genesis a class airship";
                }

                else if (name == "Cess185")
                {
                    aircraftSpecs.GetComponent<Text>().text = "This is the cessna185 a class airship";
                }

                else if (name == "Boeing747Target")
                {
                    aircraftSpecs.GetComponent<Text>().text = "This is the b747 a class airship";
                }

                else if (name == "AirBalloonBP")
                {
                    aircraftSpecs.GetComponent<Text>().text = "This is an air balloon a class airship";
                }

                else if(name == "Bell206L4")
                {
                    aircraftSpecs.GetComponent<Text>().text = "This is the bell a class airship";
                }

            }


        }

    }
}
