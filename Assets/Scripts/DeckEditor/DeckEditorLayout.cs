using UnityEngine;

public class DeckEditorLayout : MonoBehaviour
{
    public const float WidthCheck = 1300f;
    public static readonly Vector2 DeckButtonsLandscapePosition = new Vector2(-750f, 0f);

    public Vector2 DeckButtonsPortraitPosition => new Vector2(0f, -(GetComponent<RectTransform>().rect.height + 87.5f));

    public RectTransform deckButtons;

    void Start()
    {
        if (GetComponent<RectTransform>().rect.width < WidthCheck)
            deckButtons.anchoredPosition = DeckButtonsPortraitPosition;
    }

    void OnRectTransformDimensionsChange()
    {
        if (!gameObject.activeInHierarchy)
            return;

        deckButtons.anchoredPosition = GetComponent<RectTransform>().rect.width < WidthCheck ? DeckButtonsPortraitPosition : DeckButtonsLandscapePosition;
    }
}
