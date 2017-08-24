using System;
using System.Threading.Tasks;
using Cubo.Core.Domain;
using Cubo.Core.Repositories;
using FluentAssertions;
using Xunit;

namespace Cubo.Tests.Repositories
{
    public class BucketRepositoryTests
    {
        [Fact]
        public async Task add_async_should_create_new_bucket()
        {
            //Arrange
            var repository = new InMemoryBucketRepository();
            var name = "test";
            var bucket = new Bucket(Guid.NewGuid(), name);

            //Act
            await repository.AddAsync(bucket);

            //Assert
            var createdBucket = await repository.GetAsync(name);
            Assert.Same(bucket, createdBucket);

            bucket.ShouldBeEquivalentTo(createdBucket);
        }
    }
}