The events system is a simple extension to system actions that makes sure no method is over-subscribed to. It also makes it easier to create events of custom types without needing to write a load of extra code. 

# Usage
## Event Creation
To get started with the events system you'll need to first create an event. This can either be in the <code>Events.cs</code> class provided in this library or in any static class of your own. Its recommended to use a static class for ease of access to the events. To define an event, write something like the examples below:

![evt1](https://user-images.githubusercontent.com/33253710/156997440-e86737ad-98ed-43fd-a512-c72343a90104.png)

Making the events readonly just helps us not edit it accidentally and defining it as a new event is just cleaner as it won't need to be initialized anywhere else before use. 

For events with parameters there are 8 extra classes in the <code>Evt.cs</code> file that allow for it. If you need more parameters you can make additional ones as they all follow the same setup, just with an extra generic field to use in the class. To define a parameter event, use something like the following:

![evt2](https://user-images.githubusercontent.com/33253710/156997458-682286c1-4d1d-428d-afc7-d5caf055a046.png)
  
## Event Subscribing
  Subscribing to events is as easy as it is to do with actions. Instead of using <code>+=</code> or <code>-=</code> to subscribe, the events system has 2 simple methods, being <code>Add()</code> & <code>Remove()</code>. Not that any method subscribing to an event will need to have the same amount of parameters of the same type to subscribe correctly. Some examples using the same events defined in the creation section above: 

![Events Example](https://user-images.githubusercontent.com/33253710/156997490-b1e43722-caa3-4387-b5d7-dc46a54edf2a.png)

## Event Raising
