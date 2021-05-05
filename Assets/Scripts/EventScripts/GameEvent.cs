using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this stores all game listeners throughout the game. You can create a GamEvent asset add a GameEventListener to an object and assign the event asset to that listener
[CreateAssetMenu(fileName = "GameEvent", menuName = "Scriptable Events/GameEvent", order = 0)]
public class GameEvent : ScriptableObject {

   private readonly List <GameEventListener> eventListeners = new List<GameEventListener>();

    //Iterate though each listener and broadcast when an event has occured
   public void Raise(){
        for (int i = eventListeners.Count - 1; i >= 0; i--){
            eventListeners[i].OnEventRaised();
        }
   }

   public void RegisterListener(GameEventListener listener){
        if(!eventListeners.Contains(listener)){
            eventListeners.Add(listener);
        }
   }

   public void UnRegisterListener(GameEventListener listener){
        if(eventListeners.Contains(listener)){
            eventListeners.Remove(listener);
        }
   }    
}
