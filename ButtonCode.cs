using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is just a test for the buttons 
// buttons can be added from GameObjects->UI
// After we created one , we add the script into it
// to make the button write to log on click , we go to OnClick() funtion in the right 
// press "+" and add the button , then sellect the funtion

public class TextBox : MonoBehaviour
{
    public void OnButtonPress()
    {
        Debug.Log("hello");
    }
}
