using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGAme : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject.Find("Menu").GetComponent<MainMuen>().Reset();
    }
}
