# Patterns
The way of describing solutions to common design problems. C#

Visitor:
--------
The Visitor pattern allows you to define an operation for objects of other classes without changing these classes.
When using the Visitor pattern, two class hierarchies are defined: one for the elements for which you want to define a new operation, and a second hierarchy for the visitors that describe the given operation.
Use pattern:
  when there are many objects of heterogeneous classes with different interfaces, and it is necessary to perform a number of operations on each of these objects;
  when classes need to add the same set of operations without changing those classes;
  when new operations are often added to classes, while the overall structure of the classes is stable and practically does not change.

Command:
--------
The Command pattern allows you to encapsulate a request to perform a specific action as a separate object. This action request object is called a command. In this case, the objects that initiate requests to perform an action are separated from the objects that perform this action.
Commands can use parameters that convey information associated with the command. Additionally, commands can be queued and can also be cancelled.
Use pattern:
  when it is necessary to pass as parameters certain actions called in response to other actions. That is, when reverse action functions are needed in response to certain actions;
  when it is necessary to ensure the execution of a queue of requests, as well as their possible cancellation;
  when it is necessary to support logging of changes as a result of requests. Using logs can help restore the state of the system - for this you will need to use a sequence of logged commands.

# SOLID
Open/Closed principal:
----------------------
The main point of this principle is that the system should be built in such a way that all its subsequent changes should be implemented by adding new code, and not changing the existing one.
