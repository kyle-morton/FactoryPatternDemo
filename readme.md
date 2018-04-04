# Factory (*Creational Design Pattern*)

## Basic Concept 
- Use a specialized object solely to create other objects, like a real-world factory. 
- Abstract object creation abstracted away from client so it can focus on it's specific role in the application (*seperation of concerns*).

<br/>

## Actors

- __Client__
  - Object that requires an instance of another class (view model, code-behind, etc).
  - Rather than creating it itself, delegates this to the factory.
- __Factory__
  - Once invoked, creates a new instance of the product and passes it back to client.
- __Product__
  - Object that the client requires which is produced by the factory.



![Client-Factory-Product](https://i-msdn.sec.s-msft.com/dynimg/IC59654.gif)

