using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this can be any event, but this will call the "Raise" method in the GameEvent class
public class ButtonClicked : MonoBehaviour
{
    public GameEvent buttonClicked;

    public void ClickButton(){
        buttonClicked.Raise();
    }
}
