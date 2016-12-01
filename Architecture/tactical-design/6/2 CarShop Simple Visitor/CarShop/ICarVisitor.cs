namespace CarShop
{
    interface ICarVisitor: ICarPartVisitor
    {
        void Visit(Car car);
    }
}
