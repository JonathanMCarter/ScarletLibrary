The events system is a simple extension to system actions that makes sure no method is over-subscribed to. It also makes it easier to create events of custom types without needing to write a load of extra code. 

# Usage
## Event Creation
To get started with the events system you'll need to first create an event. This can either be in the <code>Events.cs</code> class provided in this library or in any static class of your own. To define an event, write something like the examples below:

>```public static readonly Evt OnGameOver = new Evt();```

Making the events readonly just helps us not edit it accidentally and defining it as a new event is just cleaner as it won't need to be initialized anywhere else before use. 

For events with parameters there are 8 extra classes in the <code>Evt.cs</code> file that allow for it. If you need more parameters you can make additional ones as they all follow the same setup, just with an extra generic field to use in the class. To define a parameter event, use something like the following:

>```public static readonly Evt<int> OnScoreUpdate = new Evt<int>();```
  
## Event Subscribing
  
## Event Raising
