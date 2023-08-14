using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public string[] trail_mix;
    public AudioClip[] trail_audio;
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

    public Animator animDog;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        if (selectedOption == GameMode.Debug)
        {
            trail = this.GetComponent<WordTrails>().trailA;
            trail_mix = this.GetComponent<WordTrails>().trailA_mix;
            trail_audio = this.GetComponent<WordTrails>().trailA_voice;
        }

        StartWord();
    }

    public void StartWord()
    {
        gamePause = false;
        currentWord = trail[currentLevel];
        currentMix = trail_mix[currentLevel + 1];
        answerWord = trail[currentLevel + 1];

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
        }

        if (selectedOption == GameMode.Debug)
        {
            diff = 5;
        }
        int rnd = Random.Range(0, diff-1);
        for (int i =0; i<= mixSpace.Length - 1; i++)
        {
            mixSpace[i].SetActive(false);
        }
        for (int i =0; i <= diff-1; i++)
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

    }

    public void LetterChanged()
    {
        string ans = "";
        for (int i = 0; i <= workSpace.transform.childCount - 1; i++)
        {
            ans += workSpace.transform.GetChild(i).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
        }
        StartCoroutine(CheckAnswer(ans));
    }


    public IEnumerator CheckAnswer(string word)
    {
        if (word == answerWord)
        {
            PlayAudio(sndFX, sfxChoiceRight);
            animDog.Play("correct");
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
            animDog.Play("wrong");
        }
    }

    public void PlayAudio(AudioSource player, AudioClip snd)
    {
        player.clip = snd;
        player.Play();
    }

    public void PlayVoice()
    {
        PlayAudio(sndVA, trail_audio[currentLevel + 1]);
        animDog.Play("hint");
    }
}
