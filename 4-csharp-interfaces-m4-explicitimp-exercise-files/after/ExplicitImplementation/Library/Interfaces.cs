
namespace Library
{
    public interface ISaveable
    {
        string Save();
    }

    public interface IPersistable
    {
        string Save();
    }

    public interface IVoidSaveable
    {
        void Save();
    }
}
