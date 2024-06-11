using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public void StartJump()
    {
        LeanTween.moveLocal(gameObject, new Vector2(825, 120), 1).setEaseInOutQuad().setLoopPingPong();
        //transform.LeanMoveLocal(new Vector2(825, 120), 1).setEaseInOutQuad().setLoopPingPong();
    }
}
