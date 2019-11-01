using System;
using Xunit;
using todos.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace todos.tests
{
    public class TodoControllerTests
    {
        [Fact]
        public void Get_Returns_List_of_Todos()
        {
            var underTest = new TodoController();

            var result = underTest.Get();

            Assert.Equal(3, result.Value.Count());
        }

        [Fact]
        public void Post_Creates_New_Todo()
        {
            var underTest = new TodoController();

            var result = underTest.Post("New task");

            Assert.Contains("New task", result.Value);
        }
    }
}
