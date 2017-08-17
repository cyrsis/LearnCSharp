using System.Data;
using SalesModel.DomainClasses;

namespace SalesModel.DataLayer
{
  public static class StateHelpers
  {
    public static EntityState ConvertState(State state)
    {
      switch (state)
      {
        case State.Added:
          return EntityState.Added;
        case State.Modified:
          return EntityState.Modified;
        case State.Deleted:
          return EntityState.Deleted;
        default:
          return EntityState.Unchanged;
      }
    }
  }
}
