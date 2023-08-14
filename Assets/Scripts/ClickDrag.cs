using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CanvasGroup))]
[RequireComponent(typeof(Collider2D))]
public class ClickDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isDragging = false;
    public Canvas canvas;
    public RectTransform rectTransform;
    public CanvasGroup canvasGroup;
    public bool canMove;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = FindObjectOfType<Canvas>();
    }
    private void Start()
    {
        if (!canMove) { this.enabled = false; }

    }

    private void Update()
    {
        if (isDragging)
        {
            MoveUIWithMouse();
            if (Input.GetMouseButtonUp(0))
            {
                StartCoroutine(MouseDelay());
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        canvasGroup.blocksRaycasts = false;
        GameManager.instance.heldLetter = this.rectTransform;
        this.transform.SetAsLastSibling();
        GameManager.instance.PlayAudio(GameManager.instance.sndFX, GameManager.instance.sfxLetterPick);
        StopCoroutine(MouseDelay());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        StartCoroutine(MouseDelay());
    }

    private void MoveUIWithMouse()
    {
        Vector2 localPointerPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out localPointerPosition))
        {
            rectTransform.anchoredPosition = localPointerPosition;
        }
    }

    public IEnumerator MouseDelay()
    {
        yield return new WaitForSeconds(0.1f);
        isDragging = false;
        canvasGroup.blocksRaycasts = true;
        GameManager.instance.heldLetter = null;
        GameManager.instance.PlayAudio(GameManager.instance.sndFX, GameManager.instance.sfxLetterPlace);
    }
}
