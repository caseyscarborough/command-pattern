% Command Design Pattern
% Casey Scarborough
% October 3, 2013

# What is the Command Design Pattern?

Definition from [Wikipedia](http://en.wikipedia.org/wiki/Command_pattern):

> _The command pattern is a behavioral design pattern in which an object is used to represent and encapsulate all the information needed to call a method at a later time. This information includes the method name, the object that owns the method and values for the method parameters._

In simpler terms, the Command Design pattern gives you a way to execute commands, keep track of them, redo or undo them, along with some other features.

# Parts of the Pattern

The Command Design pattern has five main parts: a _Command_ interface, a _ConcreteCommand_, a _Receiver_, an _Invoker_, and a _Client_. An explanation of these parts is as follows:

* The _Command_ interface declares the methods that will be used for executing an operation.
* The _ConcreteCommand_ will implement the _Command_ interface and also defines a binding between a _Receiver_ and an action.
* The _Client_ handles the creation of the command object and will set its receiver.
* The _Invoker_ asks the command to carry out the request. It actually _invokes_ the command.
* The _Receiver_ knows how to perform the operations associated with each request.

This may seem a little complex, but it will all come together soon enough. The following figure shows the UML diagram for the pattern.

![UML Diagram for the Command Pattern](images/command_pattern.png)

# Resources

* [Wikipedia](http://en.wikipedia.org/wiki/Command_pattern)
* [OODesign](http://www.oodesign.com/command-pattern.html)
* [DoFactory](http://www.dofactory.com/Patterns/PatternCommand.aspx)