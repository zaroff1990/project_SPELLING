using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public GameObject prefabLetter;
    public string currentWord = "";
    public string answerWord = "";
    public string currentMix = "";

    public GameObject workSpace;
    public GameObject[] mixSpace;

    public RectTransform heldLetter;

    [System.Flags]
    public enum GameMode
    {
        Debug = 0,
        Easy = 1 << 0,
        Medium = 1 << 1,
        Hard = 1 << 2,
    }
    public int diff = 0;
    [SerializeField]
    private GameMode selectedOption;

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
    public string vidIdle = "https://zaroffmars.com/wp-content/uploads/spell2/idle.mp4";
    public string vidHappy = "https://zaroffmars.com/wp-content/uploads/spell2/happy.mp4";
    public string vidSad = "https://zaroffmars.com/wp-content/uploads/spell2/sad.mp4";

    public static string isSubbed;
    public static DateTime subEnds = DateTime.Now;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        isSubbed = PlayerPrefs.GetString("isSubscribed", "no");
        StartWord();
    }

    public void StartWord()
    {
        gamePause = false;
        currentWord = trail[currentLevel];
        answerWord = trail[currentLevel + 1];
        trail_audio = Resources.Load<AudioClip>("voice_hailey_" + answerWord);
        currentMix = FindDifferentCharacters(currentWord, answerWord);
        animDog.url = vidIdle;
        animDog.isLooping = true;
        animDog.Play();
        LetterPiece[] objectsWithMyScript = FindObjectsOfType<LetterPiece>();
        foreach (LetterPiece script in objectsWithMyScript)
        {
            script.KillPiece();
        }

        for (int i = 0; i <= currentWord.Length - 1; i++)
        {
            GameObject tmp = Instantiate(prefabLetter);
            tmp.transform.SetParent(workSpace.transform);
            tmp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = currentWord[i].ToString();
            tmp.transform.GetComponent<ClickDrag>().enabled = false;
            tmp.transform.GetComponent<LetterPiece>().answerSpace = true;
            tmp.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (selectedOption == GameMode.Debug)
        {
            diff = 5;
        }
        int rnd = UnityEngine.Random.Range(0, diff - 1);
        for (int i = 0; i <= mixSpace.Length - 1; i++)
        {
            mixSpace[i].SetActive(false);
        }
        for (int i = 0; i <= diff - 1; i++)
        {
            if (i == rnd) { mixSpace[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = currentMix; }
            else { mixSpace[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = this.GetComponent<WordTrails>().alphabet[UnityEngine.Random.Range(0, this.GetComponent<WordTrails>().alphabet.Length - 1)]; }
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
        if (word == answerWord)
        {
            PlayAudio(sndFX, sfxChoiceRight);
            animDog.url = vidHappy;
            animDog.isLooping = false;
            animDog.Play();
            StartCoroutine(timeVideo(1f));
            gamePause = true;
            yield return new WaitForSeconds(1f);
            if (currentLevel < trail.Length - 1)
            {
                currentLevel++;
                StartWord();
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
    static string FindDifferentCharacters(string str1, string str2)
    {
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
    }

}