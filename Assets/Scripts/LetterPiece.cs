using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class LetterPiece : MonoBehaviour, IPointerDownHandler
{
    public RectTransform rectTransform1; // Assign the first RectTransform in the inspector
    public RectTransform rectTransform2; // Assign the second RectTransform in the inspector
    private Canvas canvas;
    public GameObject letter;

    public string heldLetter;
    public GameObject heldObj;
    public GameObject prefabLetter;

    public bool answerSpace = false;

    public Vector2 startingPos;

    private void Start()
    {
        heldLetter = null;
        rectTransform1 = this.GetComponent<RectTransform>();
        startingPos = rectTransform1.anchoredPosition;
        canvas = FindObjectOfType<Canvas>();
        letter = this.transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        rectTransform2 = GameManager.instance.heldLetter;
        if (rectTransform2 == null || rectTransform2 == rectTransform1)
        {
            if (letter.GetComponent<Animator>().enabled)
            {
                letter.GetComponent<TextMeshProUGUI>().color = Color.white;
                letter.GetComponent<Animator>().enabled = false;
            }
            return;
        }
        if (RectOverlaps(rectTransform1, rectTransform2))
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (answerSpace)
                {
                    heldLetter = letter.GetComponent<TextMeshProUGUI>().text;
                    letter.GetComponent<TextMeshProUGUI>().text = rectTransform2.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
                    letter.GetComponent<TextMeshProUGUI>().color = Color.yellow;
                    rectTransform2.gameObject.GetComponent<ClickDrag>().StopCoroutine(rectTransform2.gameObject.GetComponent<ClickDrag>().MouseDelay());
                    GameManager.instance.heldLetter = null;
                    heldObj = rectTransform2.gameObject;
                    rectTransform2.gameObject.SetActive(false);
                    GameManager.instance.LetterChanged();
                }
                else
                {
                    rectTransform2.gameObject.GetComponent<ClickDrag>().isDragging = false;
                    rectTransform2.gameObject.GetComponent<ClickDrag>().canvasGroup.blocksRaycasts = true;
                    GameManager.instance.heldLetter = null;
                    rectTransform2.anchoredPosition = rectTransform2.gameObject.GetComponent<LetterPiece>().startingPos;
                }
            }
            if (!letter.GetComponent<Animator>().enabled && answerSpace)letter.GetComponent<Animator>().enabled = true;
        }
        
        else
        {
            if (letter.GetComponent<Animator>().enabled)
            {
                letter.GetComponent<TextMeshProUGUI>().color = Color.white;
                letter.GetComponent<Animator>().enabled = false;
            }
        }
    }

    public bool RectOverlaps(RectTransform rectTransform1, RectTransform rectTransform2)
    {
        // Convert the RectTransform's corners to screen space
        Vector3[] corners1 = new Vector3[4];
        Vector3[] corners2 = new Vector3[4];
        rectTransform1.GetWorldCorners(corners1);
        rectTransform2.GetWorldCorners(corners2);

        Rect rect1 = new Rect(
            RectTransformUtility.WorldToScreenPoint(canvas.worldCamera, corners1[0]).x,
            RectTransformUtility.WorldToScreenPoint(canvas.worldCamera, corners1[0]).y,
            rectTransform1.rect.width,
            rectTransform1.rect.height
        );

        Rect rect2 = new Rect(
            RectTransformUtility.WorldToScreenPoint(canvas.worldCamera, corners2[0]).x,
            RectTransformUtility.WorldToScreenPoint(canvas.worldCamera, corners2[0]).y,
            rectTransform2.rect.width,
            rectTransform2.rect.height
        );

        return rect1.Overlaps(rect2);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (heldLetter != null)
        {
            letter.GetComponent<TextMeshProUGUI>().text = heldLetter;
            letter.GetComponent<TextMeshProUGUI>().color = Color.white;
            heldObj.SetActive(true);
            heldLetter = null;
        }
    }

    public void KillPiece()
    {
        if (answerSpace)
        {
            Destroy(this.gameObject);
        }
    }
}