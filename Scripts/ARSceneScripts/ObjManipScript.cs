using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjManipScript : MonoBehaviour
{
    bool scaleIsEnabled = true;
    bool yAxisRotationEnabled = false;
    bool freeRotationEnabled = false;

    private void Start()
    {
        GetComponent<Lean.Touch.LeanRotateCustomAxis>().enabled = false;
        GetComponent<Lean.Touch.LeanRotate>().enabled = false;

    }

    public void LeanTouchModesToggles()
    {
        if(scaleIsEnabled == true)
        {
            GetComponent<Lean.Touch.LeanScale> ().enabled = false;
            GetComponent<Lean.Touch.LeanRotateCustomAxis>().enabled = true;

            yAxisRotationEnabled = true;
            scaleIsEnabled = false;
        }

        else if(scaleIsEnabled == false && yAxisRotationEnabled == true)
        {
            GetComponent<Lean.Touch.LeanRotate>().enabled = true;
            GetComponent<Lean.Touch.LeanRotateCustomAxis>().enabled = false;

            yAxisRotationEnabled = false;
            freeRotationEnabled = true;

        }

        else if(scaleIsEnabled == false && yAxisRotationEnabled == false)
        {
            GetComponent<Lean.Touch.LeanScale>().enabled = true;
            GetComponent<Lean.Touch.LeanRotate>().enabled = false;

            scaleIsEnabled = true;
            freeRotationEnabled = false;
        }

    }

}
