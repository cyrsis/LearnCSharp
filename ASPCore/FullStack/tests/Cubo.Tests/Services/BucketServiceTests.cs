using System;
using System.Threading.Tasks;
using AutoMapper;
using Cubo.Core.Domain;
using Cubo.Core.DTO;
using Cubo.Core.Mappers;
using Cubo.Core.Repositories;
using Cubo.Core.Services;
using FluentAssertions;
using Moq;
using Xunit;

namespace Cubo.Tests.Services
{
    public class BucketServiceTests
    {
        [Fact]
        public async Task add_async_should_create_new_bucket()
        {
            //Arrange
            var repository = new InMemoryBucketRepository();
            var service = new BucketService(repository, AutoMapperConfig.GetMapper());
            var name = "test";

            //Act
            await service.AddAsync(name);

            //Assert
            var bucketDto = await service.GetAsync(name);
            Assert.Equal(name, bucketDto.Name);
        }  

        [Fact]
        public async Task add_async_should_invoke_repository_method()
        {
            //Arrange
            var name = "test";
            var repositoryMock = new Mock<IBucketRepository>();
            var mapperMock = new Mock<IMapper>();
            var service = new BucketService(repositoryMock.Object, mapperMock.Object);

            //Act
            await service.AddAsync(name);

            //Assert
            repositoryMock.Verify(x => x.AddAsync(It.IsAny<Bucket>()), Times.Once());
        }  

        [Fact]
        public async Task get_async_should_return_bucket()
        {
            //Arrange
            var name = "test";
            var bucket = new Bucket(Guid.NewGuid(), name);
            var dto = new BucketDTO
            {
                Name = bucket.Name
            };
            var repositoryMock = new Mock<IBucketRepository>();
            var mapperMock = new Mock<IMapper>();

            repositoryMock.Setup(x => x.GetAsync(name))
                .Returns(Task.FromResult(bucket));
            mapperMock.Setup(x => x.Map<BucketDTO>(bucket))
                .Returns(dto);
                
            var service = new BucketService(repositoryMock.Object, mapperMock.Object);

            //Act
            var bucketDto = await service.GetAsync(name);

            repositoryMock.Verify(x => x.GetAsync(name), Times.Once());
            mapperMock.Verify(x => x.Map<BucketDTO>(bucket), Times.Once());
        }  
    }
}