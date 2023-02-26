// add these using clauses
using ANTLR;
using Antlr4.Runtime;

// example expression
var expression = "\"HELLO\" AND 123";
 
var inputStream = new AntlrInputStream(expression);
var lexer = new QueryLanguageLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new QueryLanguageParser(tokenStream);
 
var visitor = new QueryLanguageVisitor();
var query = parser.query();
var result = visitor.Visit(query);

Console.WriteLine(result);