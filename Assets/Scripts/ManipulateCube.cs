using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This stores the necessary data and methods that are Responses to an event
public class ManipulateCube : MonoBehaviour
{
    public Color[] allColors;
    private int colCounter = 0;
    public void newColor(){
        colCounter++;
        this.GetComponent<Renderer>().material.color = allColors[colCounter%allColors.Length];
    }

    public Vector3[] allPos;
    private int moveCounter = 0;
    public void newPos(){
        moveCounter++;
        this.transform.position = allPos[moveCounter%allPos.Length];
    }
}
