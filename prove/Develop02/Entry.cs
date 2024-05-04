using System;
using System.Collections.Generic;
// IO, It is to use LoadFromFile method wich contain SteamWriter and StreamReader.
using System.IO;

public class Entry{
    // get and set are Auto-Implemented Properties, 'get' to retrieve the value and 'set' to asign a value to the property.
    public int Id { get; set; }
    public string Date { get; set; }
    public string Description { get; set; }
    public string Value { get; set; }
}