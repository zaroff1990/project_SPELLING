using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MenuButton : MonoBehaviour
{
    public string unit = "";
    public string chapter = "";
    public string level = "";

    private void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void Unlock()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = unit;
        transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = chapter;
        transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = level;
        transform.GetChild(3).gameObject.SetActive(true);
        transform.GetChild(4).gameObject.SetActive(false);
    }
    public void Lock()
    {
        if (chapter != "CVC Words")
        {
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
            transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "LOCKED";
            transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(4).gameObject.SetActive(true);
        }

    }
}
