# Description

It is a simple test showing how to use the null object pattern.
Instead of always verifying if an instance is null, we create a new class that will be placed in case of unimplemented code and we decide what is this object behavior.

This simple test also makes use of SOLID principles:
-   Separeted classes with their own responsibilities (SRP)
-   The Program class uses a factory to get an object, so it is opened for extension and closed for modification. (OCP)
-   The child classes can substitute the base class without compromising its functionality, achieving that by using abstract class and methods (LSP)

