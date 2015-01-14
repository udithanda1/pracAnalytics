﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleStore;
using VehicleStore.Models;
using VehicleStore.Controllers;

namespace VehicleStore.Tests.Controllers
{
    [TestClass]
    public class VehiclesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            VehiclesController controller = new VehiclesController();

            // Act
            IEnumerable<VehicleInfo> result = controller.GetAllVehicles();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Console.WriteLine(result.ElementAt(0));
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        //[TestMethod]
        //public void GetById()
        //{
        //    // Arrange
        //    VehiclesController controller = new VehiclesController();

        //    // Act
        //    string result = controller.Get(5);

        //    // Assert
        //    Assert.AreEqual("value", result);
        //}

        //[TestMethod]
        //public void Post()
        //{
        //    // Arrange
        //    VehiclesController controller = new VehiclesController();

        //    // Act
        //    controller.Post("value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Put()
        //{
        //    // Arrange
        //    VehiclesController controller = new VehiclesController();

        //    // Act
        //    controller.Put(5, "value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Delete()
        //{
        //    // Arrange
        //    VehiclesController controller = new VehiclesController();

        //    // Act
        //    controller.Delete(5);

        //    // Assert
        //}
    }
}
