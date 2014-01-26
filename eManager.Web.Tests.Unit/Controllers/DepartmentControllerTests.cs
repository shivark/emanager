using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eManager.Web;
using Rhino.Mocks;
using eManager.Web.Controllers;
using eManager.Core;

namespace eManager.Web.Tests.Unit.Controllers
{
    [TestFixture]
    class DepartmentControllerTests
    {
        DepartmentsController _controller;
        IDepartmentRepository _repository;
/*
        [SetUp]
        public void SetUp() 
        {
            _repository = MockRepository.GenerateMock<IDepartmentRepository>();
           // _controller = new DepartmentsController(_repository);
        }

        [Test]
        public void Index_Always_CallsDepartmentRepository() 
        {
            //arrange

            //act
            _controller.Index();

            //assert
            _repository.AssertWasCalled(r => r.GetAll());
        }

        */
    }
        
}