using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Lists.AnObservableCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			ObservableCollection<string> presidents = new ObservableCollection<string>
			{
				"Jimmy Carter",
				"Ronald Reagan",
                "George HW Bush"
			};
			presidents.CollectionChanged += OnCollectionChanged;

            presidents.Add("Bill Clinton");
            presidents.Remove("Jimmy Carter");

			foreach (string president in presidents)
				Console.WriteLine(president);

		}

		// stop the debugger on calls to this and examine e to see what properties are available
		// telling you what's changed in the collection
		static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
		}

	}
}
