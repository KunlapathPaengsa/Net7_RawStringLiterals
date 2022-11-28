// https://twitter.com/okyrylchuk/status/1527003752187707395

string name = "Oleg", surname = "Kyrylchuk", test = "5";

string jsonString = 
    $$"""
    {
        "Name": {{name}},
        "Surname": {{surname}},
        "Test" : {{test}}
    }
    """;

Console.WriteLine(jsonString);
