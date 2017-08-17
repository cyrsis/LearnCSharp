using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using SalesModel.DomainClasses.Annotations;

namespace SalesModel.DomainClasses
{
 public class StateInfo:INotifyPropertyChanged

  {
    public DateTime ModifiedDate { get; set; }
   [NotMapped] 
   public bool IsDirty { get; set; }

   public event PropertyChangedEventHandler PropertyChanged;

   [NotifyPropertyChangedInvocator]
   protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
   {
     IsDirty = true;
     PropertyChangedEventHandler handler = PropertyChanged;
     if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
   }
  }
}
