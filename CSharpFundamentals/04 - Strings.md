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
`\\`	  |    Backslash	             |  
\'  	  |    Single Quotation Mark	 |  
\"	      |    Double Quotation Mark	 |  


## Verbatim Strings

```
string path = "c:\\projects\\project1\\folder1";

string path = @"c:\projects\project1\folder1";
```



## Formating Strings

* ToLower() --> // "hello world"
* ToUpper() --> // "HELLO WORLD"
* Trim()    --> gets rid of the white spaces around the string



## Searching

* IndexOf('a')              --> returns index of the first occurrence of a given char or string in your string
* LastIndexOf("Hello")      --> returns index of the last occurrence of a given char or string in your string



## Substrings

* Substring(startIndex)             --> retrieves all characters from that point until the end of the string
* Substring(startIndex, length)     --> takes a length in order to limit the number of characters to retrieve



## Replacing

* Replace('a', '!')
* Replace("enea", "eneax")



## Null checking

* String.isNullOrEmpty(str)
* String.isNullOrWhiteSpace(str)



## Splitting

* str.Split(' ')



## Converting Strings to Numbers

```
string s = "1234";
int i = int.Parse(s);
int j = Convert.ToInt32(s);
```

If the string is 'null' or 'empty':
- int.Parse() will throw an exception
- Convert.ToInt32() will return the default value for an integer, which is 0



## Converting Numbers to Strings

```
int i = 1234;

string s = i.ToString();        // "1234"
string t = i.ToString("C");     // "$1,234.00"
string t = i.ToString("C0");     // "$1,234"
```



## Format Strings

Format Specifier  |         Description          |                   Examples                   |
------------------|------------------------------|----------------------------------------------|
    c or C        |          Currency            |  123456 (C)              --> $123,456        |
    d or D        |          Decimal      	     |  1234 (D6)               --> 001234          |
    e or E	      |          Exponential	     |  1052.0329112756 (E)     --> 1.052033E+003   |
    f or F	      |          Fixed Point     	 |  1234.567 (F1)           --> 1234.5          |
    x or X        |          Hexadecimal    	 |  255 (X)                 --> FF              |



## StringBuilder

Strings are immutable, but if you need to make a lot of manipulation, then StringBuilder can be useful.
StringBuilder is a class defined in System.Text namespace and it represents a mutable string.

Although it makes easy and fast to create and manipulate strings, it is not optimized for searching.
Indeed, it lacks of methods like: IndexOf(), LastIndexOf(), Contains(), StartsWith().

However, it provides some other string manipulation methods, like:
- Append()
- Insert()
- Remove()
- Replace()
- Clear()