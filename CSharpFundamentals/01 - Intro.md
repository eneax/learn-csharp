# Intro to C#

## C# vs .NET

- C# is a programming language
- .NET is a framework. It consists of two components: a run-time environment (CLR) and a class library that we use for building applications.


## CLR

When you compile your C# code, the result is called Intermediate Language (IL) Code. 
IL code is platform agnostics, which means that it is independent of the computer where the code is running.

Once we have the IL code, we need something to translate it into native code of the machine that is running the application.
CLR transforms the IL code into native code. This process is called Just-In-Time Compilation or JIT.
As long as a machine has a CLR, it can run your application written in C#. 


## Architecture of .NET Applications 

An application built in C# consists of building blocks called classes.
The classes collaborate with each other so that the app provides some functionality.

We can consider a class as a container for data (attributes) and methods (functions).
- Data represents the state of the app
- Methods have behavior (logic). They execute code and do things for us. That's where we implement our algorithms and write code.

As the number of classes in our application grows, we need a way to organize the classes. 
We do it by grouping them into various namespaces. A namespace is a container for related classes. 

As the number of classes and namespaces grows even further, we start to separate related namespaces into separate assemblies.
An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. 

An EXE file represents a program that can be executed. 
A DLL (Dynamic-link library) is a file that includes code that can be re-used across different programs.

When you compile an application, the compiler builds one or more assemblies depending on how you partition your code.


## Primitive Types 

Type	  |  Bytes	 | .NET Type  |
----------|----------|------------|
byte	  |    1	 |  Byte      |
short	  |    2	 |  Int16     |
int	      |    4	 |  Int32     |
long	  |    8	 |  Int64     |
float	  |    4	 |  Single    |
double	  |    8	 |  Double    |
decimal	  |   16	 |  Decimal   |
bool	  |    1	 |  Boolean   |
char	  |    2	 |  Char      |

In C# we can find also a few non-primitive types: string, array, class, struct (or structure).


## Reference Types and Value Types

In C#, we have two main types from which we create new types: Structures (value types) and Classes (reference types).

Structures	          |    Classes	         |
----------------------|----------------------|
Primitive Types	      |    Arrays	         |
Custom Structures	  |    Strings           |
                      |    Custom Classes    |

- Primitive Types are small types and take no more than 8 bytes.

* Value Type
    - When you create a variable that is a value type, a part of memory (called stack) is allocated to that variable
    - This memory allocation is done automatically
    - When the variable goes out of scope, it is removed immediately by the CLR

* Reference Type
    - The programmer needs to allocate memory by itself (using the 'new' operator)
    - The memory allocation happens in a different area of the memory called 'heap'
    - When the variable goes out of scope, it will continue to exist in the 'heap' for a while
    - CLR performs a process called 'Garbage collection' that will take care of removing variables from the heap 