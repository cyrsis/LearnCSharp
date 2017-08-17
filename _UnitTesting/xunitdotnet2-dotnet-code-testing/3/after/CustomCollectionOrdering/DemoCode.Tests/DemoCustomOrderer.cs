using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class AlphabeticCollectionOrderer : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {      
            var collectionOrder = testCollections.OrderBy(testCollection => testCollection.DisplayName);

            return collectionOrder;
        }
    }
}
