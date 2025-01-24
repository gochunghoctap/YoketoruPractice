using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePadInput : MonoBehaviour
{
    KeyInput keyInput = new();
    //inputValue = 1.0f * inputValue.normalized;

    void Update()
    {
        keyInput.Update();

    }

    private void FixedUpdate()
    {
        Debug.Log($"{keyInput.GetValue()}");
    }
}
