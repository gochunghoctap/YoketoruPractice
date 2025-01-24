using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControllerBench : MonoBehaviour
{
     InputController inputController = new();
 
     void Update()
     {
         inputController.Update();
     }
 
     void FixedUpdate()
     {
             var move = inputController.GetValue();
             Debug.Log($"{move}");
         }
}
