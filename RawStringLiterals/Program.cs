string name = "maxiel", surname = "dev", test = "5";

string jsonString = 
    $$"""
    {
        "Name": {{name}},
        "Surname": {{surname}},
        "Test" : {{test}}
    }
    """;

Console.WriteLine(jsonString);
