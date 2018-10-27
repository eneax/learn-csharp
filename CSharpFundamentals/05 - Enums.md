# Enums

Enums represents a set of name/value pairs (constants).
An enum is internally an integer, but it can be converted into byte.

Whenever you have a number of related constants, like:

```
const int RegularMail = 1;
const int FastMail = 2;
const int ExpressMail = 3;
```


It is preferable to use enums

```
public enum ShippingMethod
{
    RegularMail = 1,
    FastMail = 2,
    ExpressMail = 3,
}

var method = ShippingMethod.ExpressMail;
```