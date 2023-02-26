namespace ANTLR;

public class QueryLanguageVisitor : QueryLanguageBaseVisitor<string>
{
    public override string VisitString(QueryLanguageParser.StringContext context)
    {
        return context.GetText().ToLower();
    }
 
    public override string VisitNumber(QueryLanguageParser.NumberContext context)
    {
        return context.GetText();
    }
 
    public override string VisitAnd(QueryLanguageParser.AndContext context)
    {
        return Visit(context.expression(0)) + "&" + Visit(context.expression(1));
    }
 
    public override string VisitOr(QueryLanguageParser.OrContext context)
    {
        return Visit(context.expression(0)) + "|" + Visit(context.expression(1));
    }
}