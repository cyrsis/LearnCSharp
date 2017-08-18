using System;

namespace MyDSL
{
    class Program
    {
        static void Main(string[] args)
        {
            Bool a = true;
            Bool b = false;

            Bool c = !!a & b;

            Bool o = new Optimizer().Visit(c);
        }
    }

    class Optimizer : BoolVisitor
    {
        protected override Bool VisitNot(Not n)
        {
            if (n.Operand is Not)
            {
                return ((Not)n.Operand).Operand;
            }

            return base.VisitNot(n);
        }
    }

    class Bool
    {
        public static implicit operator Bool(bool b)
        {
            return new Const { Value = b };
        }

        public static Bool operator !(Bool b)
        {
            return new Not { Operand = b };
        }

        public static Bool operator &(Bool a, Bool b)
        {
            return new And { Left = a, Right = b };
        }

        public override string ToString()
        {
            return new PrintBool().Visit(this);
        }
    }

    class Const : Bool
    {
        public bool Value { get; set; }
    }

    class Not : Bool
    {
        public Bool Operand { get; set; }
    }

    class And : Bool
    {
        public Bool Left { get; set; }
        public Bool Right { get; set; }
    }

    abstract class BoolVisitor<R>
    {
        public R Visit(Bool b)
        {
            var c = b as Const;
            if (c != null)
            {
                return VisitConst(c);
            }

            var n = b as Not;
            if (n != null)
            {
                return VisitNot(n);
            }

            var a = b as And;
            if (a != null)
            {
                return VisitAnd(a);
            }

            throw new NotSupportedException();
        }

        protected abstract R VisitConst(Const c);
        protected abstract R VisitNot(Not n);
        protected abstract R VisitAnd(And a);
    }

    class BoolVisitor : BoolVisitor<Bool>
    {
        protected override Bool VisitConst(Const c)
        {
            return c;
        }

        protected override Bool VisitNot(Not n)
        {
            return new Not { Operand = Visit(n.Operand) };
        }

        protected override Bool VisitAnd(And a)
        {
            return new And { Left = Visit(a.Left), Right = Visit(a.Right) };
        }
    }

    class EvalBool : BoolVisitor<bool>
    {
        protected override bool VisitConst(Const c)
        {
            return c.Value;
        }

        protected override bool VisitNot(Not n)
        {
            return !Visit(n.Operand);
        }

        protected override bool VisitAnd(And a)
        {
            return Visit(a.Left) && Visit(a.Right);
        }
    }

    class PrintBool : BoolVisitor<string>
    {
        protected override string VisitConst(Const c)
        {
            return c.Value.ToString();
        }

        protected override string VisitNot(Not n)
        {
            return "!" + Visit(n.Operand);
        }

        protected override string VisitAnd(And a)
        {
            return "(" + Visit(a.Left) + " & " + Visit(a.Right) + ")";
        }
    }
}
