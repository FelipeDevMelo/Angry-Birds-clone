using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phase : MonoBehaviour
{
    /// <summary>
    /// this class contains the input touch phase controls(test)
    /// </summary>
    public Text txt;
    public Touch toque;

    
    void Update()
    {
        if (Input.touchCount>0)
        {
            toque = Input.GetTouch(0);
            switch (toque.phase)
            {
                case TouchPhase.Began:
                    txt.text = "began";
                    break;
                case TouchPhase.Moved:
                    txt.text = "moved";
                    break;
                case TouchPhase.Stationary:
                    txt.text = "sttionary";
                    break;
                case TouchPhase.Ended:
                    txt.text = "ended";
                    break;
                case TouchPhase.Canceled:
                    txt.text = "canceled";
                    break;
                default:
                    break;
            }
        }
    }
}
