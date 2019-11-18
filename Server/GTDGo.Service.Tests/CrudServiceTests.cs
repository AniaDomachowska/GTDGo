using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GTDGo.Repository;
using GTDGo.Repository.Model;
using GTDGo.Service.Model;
using GTDGo.Service.Service;
using Moq;
using Xunit;

namespace GTDGo.Service.Tests
{
    public class CrudServiceTests
    {
        [Fact]
        public void GetAll_Returns_All_Tasks()
        {
            // Arrange
            var mockRepository = new Mock<IBaseRepository<Task>>();
            var taskList = new List<Task>
            {
                new Task
                {
                    Name = "task1"
                }
            }.AsQueryable();

            mockRepository.Setup(element => element.GetAll()).Returns(taskList);

            var mapper = new Mock<IEntityMapper>();
            mapper
                .Setup(element => element.Map<TaskModel>(It.IsAny<Task>()))
                .Returns(new TaskModel
            {
                Name = "task1"
            });

            var testee = new CrudService<Task, TaskModel>(
                mockRepository.Object,
                mapper.Object);

            // Act
            var tasks = testee.GetList();

            // Assert
            tasks.Should().BeEquivalentTo(taskList, conf => conf.ExcludingMissingMembers());
        }
    }
}