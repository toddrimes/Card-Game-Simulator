using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckEditorLayout : MonoBehaviour
{
    public Vector2 deckButtonsLandscapePosition {
        get { return new Vector2(-377.5f, 0f); }
    }

    public Vector2 deckButtonPortraitPosition {
        get { return new Vector2(0f, -(GetComponent<RectTransform>().rect.height + 125f)); }
    }

    public RectTransform deckButtons;

    #if UNITY_ANDROID && !UNITY_EDITOR
    void Start()
    {
        if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
            deckButtons.anchoredPosition = deckButtonPortraitPosition;
    }

    void OnRectTransformDimensionsChange()
    {
        if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
            deckButtons.anchoredPosition = deckButtonPortraitPosition;
        else
            deckButtons.anchoredPosition = deckButtonsLandscapePosition;
    }
    #endif

}
