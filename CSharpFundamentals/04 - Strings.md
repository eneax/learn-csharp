# Strings

A string is a sequence of characters surrounded by double quotes (i.e. "Enea Xharja").


## Create strings

```
string firstName = "Enea";
```


String concatenation
```
string name = firstName +  " " + lastName;
```


String Format (Format is a static method)
```
string name = string.Format("{0} {1}", firstName, lastName);
```


String Join (combine numbers with a comma)
```
var numbers = new numbers[3] { 1, 2, 3 };

string list = string.Join(", ", numbers);
```


## String Elements

Strings are immutable and once you create them, you cannot change them.

```
Allowed
string name = "Enea";
char firstChar = name[0];

NOT Allowed
name[0] = "e";
```


## Escape Characters

Char	  |         Description          | 
----------|------------------------------|
\n	      |    New Line	                 |
\t	      |    Tab      	             | 
\\	      |    Backslash	             |  
\'	      |    Single Quotation Mark	 |  
\"	      |    Double Quotation Mark	 |  


## Verbatim Strings
```
string path = "c:\\projects\\project1\\folder1";

string path = @"c:\projects\project1\folder1";
```