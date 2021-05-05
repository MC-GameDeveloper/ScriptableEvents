# ScriptableEvents

This is a study on how to leverage C#'s ability to create events in tandem with Unity's Scriptable Objects. 
Referencing Ryan Hipple's Unite Austin 2017 - Game Architecture I created a simple event system. 
The structure of this projects stores a list of game event listeners in a ScriptableObject 
then iterates through each listener to trigger a response for each one when a specific event occurs.

In the case of this instance, a button gets pressed >> it Raises the event broadcast >> iterates through
all event listeners to trigger their response. 


