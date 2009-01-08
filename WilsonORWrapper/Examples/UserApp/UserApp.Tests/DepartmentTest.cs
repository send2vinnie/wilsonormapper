//------------------------------------------------------------------------------
// <autogenerated>
//		This code was generated by a CodeSmith Template.
//
//		This template is the begining of the test cases for the business objects.
//      This is not a complete set of tests. Please add more tests.
// </autogenerated>
//------------------------------------------------------------------------------

using System.Collections.ObjectModel;
using NUnit.Framework;
using Wilson.ORMapper;
using UserApp.Entities;
using UserApp.Services;

namespace UserApp.Tests
{
	/// <summary>
	/// This class is a test case for Department and DepartmentService.
	/// </summary>
	[TestFixture()]		
	public class DepartmentTest
	{
		public DepartmentTest()
		{
		}
		
		[Test()]
		public void DepartmentCreate()
		{		
			Department instance1 = new Department();
			Assert.IsNotNull(instance1, "DepartmentTest.DepartmentNew: Unable to create instance using new()");
			Department instance2 = DepartmentService.Create();
			Assert.IsNotNull(instance2, "DepartmentTest.DepartmentCreate: Unable to create instance");
		}

		[Test()]
		public void DepartmentRetrieve()
		{
			Department instance = DepartmentService.RetrieveFirst("");
			Assert.IsNotNull(instance, "Department.RetrieveFirst: null retrieved (are you missing test data?)");
			
			// TODO: Retrieve by Key, using the PKs of instance, 
			// then compare that they are equal 
			// To do this we need a GetIdentity() field on the EntityBase that returns an IIdentity
			//Assert.AreEqual(key, instance.KeyName);
		}
		
		
		[Test()]
		public void DepartmentSave()
		{		
			Department instance = new Department();
			Assert.IsNotNull(instance, "DepartmentTest.DepartmentNew: Unable to create instance using new()");
			
			//TODO Set values
			
			//instance.Save();
		}
		
		[Test()]
		public void DepartmentRetrieveAll()
		{
			Collection<Department> list = DepartmentService.Retrieve();
			Assert.IsNotNull(list, "DepartmentTest.RetrieveAll: null retrieved (are you missing test data?)"); 
			Assert.IsTrue(list.Count > 0, "DepartmentTest.RetrieveAll(): no rows retrieved (are you missing test data?)");
		}

		[Test()]
		public void DepartmentRetrievePage()
		{
			int pageSize = 10;
			int pageIndex = 1;
			int pageCount;
			
			Collection<Department> list = DepartmentService.RetrievePage(pageSize, pageIndex, out pageCount);
			Assert.IsNotNull(list, "DepartmentTest.RetrieveAll: null retrieved (are you missing test data?)");
			Assert.IsTrue(list.Count > 0, "DepartmentTest.RetrieveAll(): no rows retrieved (are you missing test data?)");
		}

	}
}
