using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupUI : MonoBehaviour
{

    public GameObject starYellow;
    public GameObject starGrey;

    // This function is always called before any Start functions and also just after a prefab is instantiated. (If a GameObject is inactive during start up Awake is not called until it is made active.)
    void Awake()
    {
        DisplayEmpty();
    }

    public void DisplayEmpty()
    {
        starYellow.SetActive(false);
        starGrey.SetActive(false);
    }

    public void DisplayYellow()
    {
        starYellow.SetActive(true);
        starGrey.SetActive(false);
    }

    public void DisplayGrey()
    {
        starYellow.SetActive(false);
        starGrey.SetActive(true);
    }
}
