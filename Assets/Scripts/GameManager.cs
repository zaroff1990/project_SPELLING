using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;
using UnityEngine.Windows;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public GameObject prefabLetter;
    public string[] currentWord;
    public string[] answerCharas;
    public string answerWord = "";
    public string currentMix = "";

    public GameObject workSpace;
    public GameObject[] mixSpace;

    public RectTransform heldLetter;

    public int diff = 0;

    public string[] trail;
    public AudioClip trail_audio;
    public int currentLevel = 0;

    public bool gamePause = false;

    public AudioSource sndBG;
    public AudioSource sndFX;
    public AudioSource sndVA;

    public AudioClip bgMain;
    public AudioClip sfxLetterPick;
    public AudioClip sfxLetterPlace;
    public AudioClip sfxChoiceRight;
    public AudioClip sfxChoiceWrong;

    public VideoPlayer animDog;
    public string vidIdle = "https://zaroffmars.com/wp-content/uploads/idle.mp4";
    public string vidHappy = "https://zaroffmars.com/wp-content/uploads/happy.mp4";
    public string vidSad = "https://zaroffmars.com/wp-content/uploads/sad.mp4";

    public static string isSubbed="no";
    public static DateTime subEnds = DateTime.Now;

    public bool wordPadding = false;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        isSubbed = PlayerPrefs.GetString("isSubscribed", "no");
    }

    private void OnEnable()
    {
        StartCoroutine(DelayStart());
    }

    public IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(0.1f);
        StartWord();
    }

    public void EndGame()
    {
        gamePause = false;
        currentWord = null;
        answerWord = null;
        trail_audio = null;
        currentMix = null;
        animDog.url = vidIdle;
        animDog.isLooping = true;
        currentLevel = 0;
        LetterPiece[] objectsWithMyScript = FindObjectsOfType<LetterPiece>();
        foreach (LetterPiece script in objectsWithMyScript)
        {
            script.KillPiece();
        }
        //GameObject.Find("Menu").GetComponent<Canvas>().enabled = true;
        this.transform.parent.gameObject.SetActive(false);
    }

    public void StartWord()
    {
        gamePause = false;

        currentWord = trail[currentLevel].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string currentCharas = "";
        answerWord = "";

        for (int i = 0; i <= currentWord.Length - 1; i++)
        {
            currentCharas += currentWord[i];
        }

        answerCharas = trail[currentLevel + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i <= answerCharas.Length - 1; i++)
        {
            answerWord += answerCharas[i];
        }
        currentMix = FindDifferentCharacters(currentWord, answerCharas);

        animDog.url = vidIdle;
        animDog.isLooping = true;
        animDog.Play();

        trail_audio = Resources.Load<AudioClip>("voice_hailey_" + answerWord);


        LetterPiece[] objectsWithMyScript = FindObjectsOfType<LetterPiece>();
        foreach (LetterPiece script in objectsWithMyScript)
        {
            script.KillPiece();
        }

        string[] uniqueChars = trail.SelectMany(word => word.ToCharArray()).Distinct().Select(c => c.ToString()).ToArray();
        //string[] gameAlpha = this.GetComponent<WordTrails>().alphabet;
        List<String> gameAlpha = new List<String>();
        //gameAlpha.AddRange(this.GetComponent<WordTrails>().alphabet);
        for (int i=0; i<= trail.Length - 1; i++)
        {
            String[] options = trail[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            gameAlpha.AddRange(options);
        }
        foreach (string ch in trail)
        {
            //gameAlpha.Add(ch);
        }

        if (currentWord.Length < answerCharas.Length)
        {
            GameObject tmp = Instantiate(prefabLetter);
            tmp.transform.SetParent(workSpace.transform);
            tmp.transform.localScale = new Vector3(1, 1, 1);
            tmp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = " ";
            tmp.transform.GetComponent<ClickDrag>().enabled = false;
            tmp.transform.GetComponent<LetterPiece>().answerSpace = true;
            tmp.transform.GetChild(1).gameObject.SetActive(true);
        }

        for (int i = 0; i <= currentWord.Length - 1; i++)
        {
            GameObject tmp = Instantiate(prefabLetter);
            tmp.transform.SetParent(workSpace.transform);
            tmp.transform.localScale = new Vector3(1, 1, 1);
            tmp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = currentWord[i].ToString();
            tmp.transform.GetComponent<ClickDrag>().enabled = false;
            tmp.transform.GetComponent<LetterPiece>().answerSpace = true;
            tmp.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (currentWord.Length < answerCharas.Length)
        {
            GameObject tmp = Instantiate(prefabLetter);
            tmp.transform.SetParent(workSpace.transform);
            tmp.transform.localScale = new Vector3(1, 1, 1);
            tmp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = " ";
            tmp.transform.GetComponent<ClickDrag>().enabled = false;
            tmp.transform.GetComponent<LetterPiece>().answerSpace = true;
            tmp.transform.GetChild(1).gameObject.SetActive(true);
        }

        int rnd = UnityEngine.Random.Range(0, diff - 1);
        for (int i = 0; i <= mixSpace.Length - 1; i++)
        {
            mixSpace[i].SetActive(false);
        }
        for (int i = 0; i <= diff - 1; i++)
        {
            if (i == rnd) { mixSpace[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = currentMix; }
            else { mixSpace[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = gameAlpha[UnityEngine.Random.Range(0, gameAlpha.Count - 1)]; }
            mixSpace[i].GetComponent<ClickDrag>().enabled = false;
            mixSpace[i].GetComponent<ClickDrag>().isDragging = false;
            mixSpace[i].GetComponent<ClickDrag>().canvasGroup.blocksRaycasts = true;
            GameManager.instance.heldLetter = null;
            mixSpace[i].GetComponent<RectTransform>().anchoredPosition = mixSpace[i].GetComponent<LetterPiece>().startingPos;
            mixSpace[i].GetComponent<ClickDrag>().enabled = true;
            mixSpace[i].SetActive(true);
        }
        PlayVoice();
    }

    public void LetterChanged()
    {
        string ans = "";
        for (int i = 0; i <= workSpace.transform.childCount - 1; i++)
        {
            ans += workSpace.transform.GetChild(i).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
        }
        StartCoroutine(CheckAnswer(ans.Trim()));
    }


    public IEnumerator CheckAnswer(string word)
    {
        if (word.ToLower() == answerWord.ToLower())
        {
            PlayAudio(sndFX, sfxChoiceRight);
            animDog.url = vidHappy;
            animDog.isLooping = false;
            animDog.Play();
            StartCoroutine(timeVideo(1f));
            gamePause = true;
            yield return new WaitForSeconds(1f);
            currentLevel++;
            if (currentLevel < trail.Length - 1)
            {
                StartWord();
            }
            else
            {
                EndGame();
            }
        }
        else
        {
            PlayAudio(sndFX, sfxChoiceWrong);
            animDog.url = vidSad;
            animDog.isLooping = false;
            animDog.Play();
            StartCoroutine(timeVideo(3f));
        }
    }

    public void PlayAudio(AudioSource player, AudioClip snd)
    {
        player.clip = snd;
        player.Play();
    }

    public void PlayVoice()
    {
        PlayAudio(sndVA, trail_audio);
    }
    public IEnumerator timeVideo(float secs)
    {
        yield return new WaitForSeconds(secs);
        animDog.url = vidIdle;
        animDog.isLooping = true;
        animDog.Play();
    }
    static string FindDifferentCharacters(string[] str1, string[] str2)
    {

        var notInStringArray1 = str2.Except(str1).ToArray();
        string find = "";
        foreach (var item in notInStringArray1)
        {
            find= item;
        }
        return find;
        /*
        Dictionary<char, int> freq1 = new Dictionary<char, int>();
        Dictionary<char, int> freq2 = new Dictionary<char, int>();

        foreach (char c in str1)
        {
            if (freq1.ContainsKey(c))
            {
                freq1[c]++;
            }
            else
            {
                freq1[c] = 1;
            }
        }

        foreach (char c in str2)
        {
            if (freq2.ContainsKey(c))
            {
                freq2[c]++;
            }
            else
            {
                freq2[c] = 1;
            }
        }

        string differentChars = "";

        foreach (var pair in freq2)
        {
            char c = pair.Key;
            int count = pair.Value;

            if (!freq1.ContainsKey(c))
            {
                differentChars += new string(c, count);
            }
            else if (freq1[c] < count)
            {
                differentChars += new string(c, count - freq1[c]);
            }
        }

        return differentChars;
        */
    }

}