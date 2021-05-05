using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    //I have used public variables if this wants to be extended for non-technical 
    //team members to create their own events and responses
    [Tooltip("what Event is triggering the respons.")]
    public GameEvent Event;
    [Tooltip("What Response will occur based on the Event.")]
    public UnityEvent Response;

    public void OnEnable() => Event.RegisterListener(this);
    public void OnDisable() => Event.UnRegisterListener(this);
        
    //Response invoke will call a method on a script attached to a class
    public void OnEventRaised(){
        Response.Invoke();
    }

}
