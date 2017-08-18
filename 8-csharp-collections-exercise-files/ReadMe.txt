Samples in this folder are for the Pluralsight course, C# Collections Fundamentals, Module 8 - Dictionaries,
by Simon Robinson.

All samples except ReadOnlyDict have been created in VS2010 and verified that they load in VS2013. ReadOnlyDict has been created in VS2013: This sample will not work in VS2010 because the ReadOnlyDictionary type requires .NET 4.5. It is likely to work in VS2012, but I haven't verified that.

Please be aware that if you follow along the module by loading one of the earlier (.NET 4.0) samples and then edit it to match later code, then you may need to change the .NET version to 4.5.

Samples Included:
PrimeMinisters Dictionary: Demos basics of using Dictionary<TKey, TValue>
CompareKeys: Demos adding a custom equality comparer to Dictionary<TKey, TValue>
ReadOnlyDict: Demos using ReadOnlyDictionary<TKey, TValue>
SortedListDemo: Demos basic use of SortedList<TKey, TValue>
SortedWithComparer: Demos adding a custom comparer to SortedList<TKey, TValue>
KeyedCollectionDemo: Demos basic use of KeyedCollection<TKey, TValue>
