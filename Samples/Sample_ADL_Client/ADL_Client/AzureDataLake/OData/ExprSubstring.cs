namespace AzureDataLake.ODataQuery
{
    public class ExprSubstring : Expr
    {
        public Expr Expression1;
        public Expr Expression2;

        public ExprSubstring(Expr expr1, Expr expr2)
        {
            this.Expression1 = expr1;
            this.Expression2 = expr2;
        }

        public override void ToExprString(ExpressionWriter sb)
        {
            this.WriteFunction2(sb, "substring", this.Expression1, this.Expression2);
        }
    }
}