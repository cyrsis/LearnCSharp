namespace CarShop
{
    interface ICarVisitor<T>: ICarVisitor
    {
        T ProduceResult();
    }
}
