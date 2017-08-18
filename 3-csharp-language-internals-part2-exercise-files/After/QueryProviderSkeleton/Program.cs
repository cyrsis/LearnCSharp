using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        var table = new Source<int>("numbers");

        var result = from x in table
                     where x > 0
                     select x * x;

        foreach (var x in result)
            Console.WriteLine(x);
    }
}

class Source<T> : IQueryable<T>
{
    private readonly string _tableName;

    public Source(string tableName)
    {
        _tableName = tableName;
    }

    public string TableName
    {
        get { return _tableName; }
    }

    public Expression Expression
    {
        get { return Expression.Constant(this); }
    }

    public IQueryProvider Provider
    {
        get { return new Provider(); }
    }

    public override string ToString()
    {
        return TableName;
    }

    #region Details

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public Type ElementType
    {
        get { return typeof(T); }
    }

    #endregion
}

class Provider : IQueryProvider
{
    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new Query<TElement>(expression);
    }

    #region Details

    public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
    {
        throw new NotImplementedException();
    }

    public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
    {
        throw new NotImplementedException();
    }

    public object Execute(System.Linq.Expressions.Expression expression)
    {
        throw new NotImplementedException();
    }

    #endregion
}

class Query<T> : IQueryable<T>
{
    private readonly Expression _expression;

    public Query(Expression expression)
    {
        _expression = expression;
    }

    public Expression Expression
    {
        get { return _expression; }
    }

    public IQueryProvider Provider
    {
        get { return new Provider(); }
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    #region Details

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public Type ElementType
    {
        get { return typeof(T); }
    }

    #endregion
}
