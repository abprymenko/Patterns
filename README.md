# Patterns
The way of describing solutions to common design problems. C#

Abstract Factory:
-----------------
Also known as: Toolkit. 
Described in the book [GoF95].
Pattern goal: Provide an interface for designing and implementing a family of interrelated and interdependent 
			  objects without specifying the concrete classes that will be created. 
The pattern should be used when...
	The system should not depend on how objects are created and composed within it.
	Objects that belong to the same family should be used together.
	The system should be configured with one of the families of objects.
	An interface of a library needs to be provided without exposing its internal implementation.

Command:
--------
Also known as: Action, Transaction.
Described in the book [GoF95].
The Command pattern allows representing a request as an object, enabling the client to configure the request 
(by specifying parameters for its processing), queue requests, log requests, and support operation cancellation..
Commands can use parameters that convey information associated with the command. 
Additionally, commands can be queued and can also be cancelled.
The pattern should be used when...
  It is necessary to pass as parameters certain actions called in response to other actions. 
	That is, when reverse action functions are needed in response to certain actions;
  when it is necessary to ensure the execution of a queue of requests, as well as their possible cancellation;
  when it is necessary to support logging of changes as a result of requests. 
	Using logs can help restore the state of the system - for this you will need to use a sequence of logged commands.

Visitor:
--------
The Visitor pattern allows you to define an operation for objects of other classes without changing these classes.
When using the Visitor pattern, two class hierarchies are defined: one for the elements for which you want to define 
a new operation, and a second hierarchy for the visitors that describe the given operation.
The pattern should be used when...
  There are many objects of heterogeneous classes with different interfaces, and it is necessary to perform 
	a number of operations on each of these objects;
  Classes need to add the same set of operations without changing those classes;
  New operations are often added to classes, while the overall structure of the classes is stable 
	and practically does not change.
  
# SOLID
Open/Closed principal:
----------------------
The main point of this principle is that the system should be built in such a way that all its subsequent changes 
should be implemented by adding new code, and not changing the existing one.
