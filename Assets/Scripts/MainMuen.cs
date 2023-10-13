using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMuen : MonoBehaviour
{
    public string[] variableNames;
    public GameObject button;

    public string unit;
    public string chapter;
    public int level;

    public string[] trail;

    public GameObject gameScreen;

    public Type myClassType;
    public WordTrails myClassInstance;

    public GameObject iap;

    public TextMeshProUGUI txtDebug;
    private void OnEnable()
    {
        if (PlayerPrefs.GetString("isSubscribed") == "no")
        {
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("button"))
            {
                gameObj.GetComponent<MenuButton>().Lock();
            }
            iap.SetActive(true);
        }
        else
        {
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("button"))
            {
                gameObj.GetComponent<MenuButton>().Unlock();
            }
            iap.SetActive(false);
        }
        GameObject.Find("LoginStatusText").GetComponent<Text>().text = "";
        GameObject.Find("RegistrationStatusText").GetComponent<Text>().text = "";
    }

    void Start()
    {

        foreach (var gameObj in GameObject.FindGameObjectsWithTag("button"))
        {
            gameObj.GetComponent<MenuButton>().Unlock();
        }

        // Get the Type of the class
        myClassType = typeof(WordTrails);

        // Get the FieldInfo objects for all public variables of MyClass
        FieldInfo[] fields = myClassType.GetFields(BindingFlags.Public | BindingFlags.Instance);

        // Initialize the string array to hold the variable names
        variableNames = new string[fields.Length];

        // Loop through the FieldInfo objects and store the names in the string array
        for (int i = 0; i < fields.Length; i++)
        {
            variableNames[i] = fields[i].Name;
        }
        level = 1;
        // Print the variable names for debugging purposes
        foreach (string name in variableNames)
        {
            if (!name.Contains("alphabet") && !name.Contains("trailA"))
            {
                myClassInstance = new WordTrails();
                FieldInfo fieldInfo = myClassType.GetField(name);
                trail = (string[])fieldInfo.GetValue(myClassInstance);
                if (trail != null)
                {
                    if (trail.Length >= 1)
                    {
                        if (name.Contains("cvc"))
                        {
                            unit = " ";
                            chapter = "CVC Words";
                        }
                        if (name.Contains("digraph"))
                        {
                            unit = " ";
                            chapter = "CVC Words Including Digraphs";
                        }
                        if (name.Contains("floss"))
                        {
                            unit = " ";
                            chapter = "FLOSS Words";
                        }
                        if (name.Contains("iCons"))
                        {
                            unit = " ";
                            chapter = "Initial Consonant Blends";
                        }
                        if (name.Contains("fCons"))
                        {
                            unit = " ";
                            chapter = "Final Consonat Blends";
                        }
                        if (name.Contains("bCons"))
                        {
                            unit = " ";
                            chapter = "Initial and Final Consonat Blends";
                        }
                        if (name.Contains("syllables"))
                        {
                            unit = " ";
                            chapter = "Open & Closed Syllables";
                        }
                        if (name.Contains("silent"))
                        {
                            unit = " ";
                            chapter = "Silent e";
                        }
                        if (name.Contains("bossy"))
                        {
                            unit = " ";
                            chapter = "Bossy r";
                        }
                        if (name.Contains("long"))
                        {
                            unit = " ";
                            chapter = "Long Vowel Teams";
                        }
                        if (name.Contains("tricky"))
                        {
                            unit = " ";
                            chapter = "Diphthongs & Tricky Vowel Teams";
                        }

                        GameObject tmp = Instantiate(button);
                        tmp.transform.parent = button.transform.parent;
                        tmp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = unit;
                        tmp.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = chapter;
                        tmp.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = level.ToString();
                        tmp.gameObject.SetActive(true);
                        tmp.gameObject.name = name;
                        tmp.transform.GetChild(3).gameObject.GetComponent<Button>().onClick.AddListener(() => GameStart(tmp.gameObject.name,unit + chapter + level.ToString()));
                        level++;
                        if (level >= 11) { level = 1; }
                        tmp.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(
                            tmp.transform.parent.GetComponent<RectTransform>().sizeDelta.x + tmp.GetComponent<RectTransform>().sizeDelta.x,
                            tmp.transform.parent.GetComponent<RectTransform>().sizeDelta.y);

                        tmp.GetComponent<MenuButton>().unit = unit;
                        tmp.GetComponent<MenuButton>().chapter = chapter;
                        tmp.GetComponent<MenuButton>().level = level.ToString();

                        if (PlayerPrefs.GetString("isSubscribed")== "no" && !name.Contains("cvc"))
                        {
                            tmp.transform.GetChild(4).gameObject.SetActive(true);
                            tmp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
                            tmp.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "LOCKED";
                            tmp.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
                            tmp.transform.GetChild(3).gameObject.SetActive(false);
                        }
                    }
                }
            }
         }
    }
    public void GameStart(string selection, string levelName)
    {
        txtDebug.text = levelName;
        myClassInstance = new WordTrails();
        FieldInfo fieldInfo = myClassType.GetField(selection);
        gameScreen.transform.GetChild(0).gameObject.GetComponent<GameManager>().trail = (string[])fieldInfo.GetValue(myClassInstance);
        gameScreen.SetActive(true);
        //this.GetComponent<Canvas>().enabled = false;
    }

    public void Reset()
    {
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("button"))
        {
            gameObj.GetComponent<MenuButton>().Unlock();
        }
        GameObject.Find("DidBuy").SetActive(false);
        iap.SetActive(false);
    }
}