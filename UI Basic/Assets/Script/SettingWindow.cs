using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.zero; 
    }

    public void Open()
    {
        //transform.LeanScale(Vector2.one, 1);
        LeanTween.scale(gameObject, Vector2.one, 1).setEaseInOutSine(); 
    }

    public void Close()
    {
        //transform.LeanScale(Vector2.zero, 1);
        LeanTween.scale(gameObject, Vector2.zero, 1).setEaseInOutSine();
    }
}
