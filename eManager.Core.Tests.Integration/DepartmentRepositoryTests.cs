using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Core.Tests.Integration
{
    [TestFixture]
    public class DepartmentRepositoryTests
    {
        IDepartmentRepository _repository;

        [SetUp]
        public void SetUp() {
            _repository = new DepartmentRepository();
        }

        [Test]
        public void GetAll_Always_ReturnsAllDepartments() 
        {

            //act
            var result =  _repository.GetAll();

            //assert
            Assert.That(result.Count() == 1);
            Assert.That(result.Any(d => d.Name == "foo"));

        }
    }
}
