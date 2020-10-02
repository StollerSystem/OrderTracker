using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test","test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor Name";
      Vendor newVendor = new Vendor(name,"test");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor ID";
      Vendor newVendor = new Vendor(name,"test");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "Bob";
      string name2 = "Peter";
      Vendor newVendor1 = new Vendor(name1,"test");
      Vendor newVendor2 = new Vendor(name2,"test");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert      
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnstVendorById_Vendor()
    {
      //Arrange
      string name1 = "Bob";
      string name2 = "Peter";
      Vendor newVendor1 = new Vendor(name1,"test");
      Vendor newVendor2 = new Vendor(name2,"test");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddOrderToVendor_OrderList()
    {
      //Arrange
      string description = "Bread Order";
      Order newOrder = new Order(description,"test","test","test");
      List<Order> newList = new List<Order> { newOrder };
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name,"test");
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void RemoveOrder_RemoveAnOrderFromVendor_EmtpyList()
    {
      //Arrange
      Vendor newVendor = new Vendor("test","test");
      Order newOrder = new Order("test","test","test","test");      
      newVendor.AddOrder(newOrder);
      List<Order> emptyList = new List<Order> { };

      //Act
      newVendor.RemoveOrder(newOrder.Id);
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(emptyList, result);

    }
  }
}