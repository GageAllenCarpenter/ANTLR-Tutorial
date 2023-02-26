using ANTLR;

var expression = "\"HELLO\" AND 123";
var result = Query.Parse(expression);

Console.WriteLine(result.Result);