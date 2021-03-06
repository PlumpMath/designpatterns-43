The Factory Method pattern defers instantiation of an object to subclasses, meaning that the client does not need to reference and create the concrete object.

We reference a factory class from the client which has an abstract 'Create' method. This can then be implemented in concrete subclasses which are responsible for returning a specific object. 

In our example, PizzaFactory is the abstract 'creator' and defines an abstract 'CreatePizza' method. This is then implemented by the concrete subclasses, 'MargheritaFactory', 'HawaianFactory' and 'BbqDeluxeFactory', which all return the relevant Pizza objects. The return type is of the parent class, Pizza, so that the client does not need to know which type of Pizza will be returned.

The client instantiates the factory with one of it's subclasses, so that we know which factory to use and therefore which conrete object to return.
