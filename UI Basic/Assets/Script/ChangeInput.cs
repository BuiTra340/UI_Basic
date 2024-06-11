using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeInput : MonoBehaviour
{
    EventSystem system;
    public Selectable firstInput;
    [SerializeField] private Button LoginButton;
    private void Start()
    {
        system = EventSystem.current;
        firstInput.Select();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            Selectable previousInput = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
            if (previousInput != null)
            {
                previousInput.Select();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable nextInput = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if (nextInput != null)
            {
                nextInput.Select();
            }
        }else if(Input.GetKeyDown(KeyCode.Return))
        {
            LoginButton.onClick.Invoke();
        }
    }

    public void LoginForm()
    {
        Debug.Log("login successful");
    }
}
