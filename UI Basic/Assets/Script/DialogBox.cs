using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
    public Transform box;
    public CanvasGroup Background;
    private void OnEnable()
    {
        box.position = new Vector2(0,-Screen.height);
        Background.alpha = 0;
        Background.LeanAlpha(1, 0.5f);
        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, .5f).setEaseOutExpo().delay = .1f;
    }

    public void CloseDialog()
    {
        Background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, .5f).setEaseOutExpo().setOnComplete(OnComplete);
    }

    private void OnComplete()
    {
        gameObject.SetActive(false);
    }
}
