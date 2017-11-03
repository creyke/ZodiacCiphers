# ZodiacCiphers
.NET Standard implementation of the [Zodiac](https://en.wikipedia.org/wiki/Zodiac_Killer) ciphers.

## How do I talk like the Zodiac Killer?
That's a really sick and disturbing question... and here's the answer!
### Encode
```
    var key = new Key408();
    var cipher = key.Encode("hello how are you", 17); // cipher width
    cipher.Symbols.ToZodiacStringGrid(17); // printout width
```
### Decode
```
    var decoded = new string(key.Decode(cipher));
```

## Zodiac 13
![Zodiac 13](/ZodiacCiphers/Images/Cipher13.jpg)

## Zodiac 340
![Zodiac 340](/ZodiacCiphers/Images/Cipher340.jpg)
