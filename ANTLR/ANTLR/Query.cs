using Antlr4.Runtime;

namespace ANTLR;

public static class Query
{
  public static ParserResult Parse(string expression, bool secondRun = false)
  {
    if (String.IsNullOrWhiteSpace(expression))
    {
      return new ParserResult
      {
        IsValid = true,
        Result = null
      };
    }

    var inputStream = new AntlrInputStream(expression);
    var lexer = new QueryLanguageLexer(inputStream);
    var tokenStream = new CommonTokenStream(lexer);
    var parser = new QueryLanguageParser(tokenStream);

    lexer.RemoveErrorListeners();
    parser.RemoveErrorListeners();
    var customErrorListener = new QueryLanguageErrorListener();
    parser.AddErrorListener(customErrorListener);
    var visitor = new QueryLanguageVisitor();

    var adaptableExpression = parser.query();
    var result = visitor.Visit(adaptableExpression);
    var isValid = customErrorListener.IsValid;
    var errorLocation = customErrorListener.ErrorLocation;
    var errorMessage = customErrorListener.ErrorMessage;
    if (result != null)
    {
      isValid = false;
    }

    if (!isValid && !secondRun)
    {
      var cleanedFormula = string.Empty;
      var tokenList = tokenStream.GetTokens().ToList();
      for (var i = 0; i < tokenList.Count - 1; i++)
      {
        cleanedFormula += tokenList[i].Text;
      }

      var originalErrorLocation = errorLocation;
      var retriedResult = Parse(cleanedFormula, true);
      if (!retriedResult.IsValid)
      {
        retriedResult.ErrorPosition = originalErrorLocation;
        retriedResult.ErrorMessage = errorMessage;
      }

      return retriedResult;
    }

    return new ParserResult
    {
      IsValid = isValid,
      Result = isValid || result != null
        ? result
        : null,
      ErrorPosition = errorLocation,
      ErrorMessage = isValid ? null : errorMessage
    };
  }
}
