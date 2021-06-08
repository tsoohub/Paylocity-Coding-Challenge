using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Models;
using Repository;

namespace Test.Unit
{
    [TestClass]
    public class EmployeeUnitTests
    {
        private IEmployeeRepository empRepo;
        private IConfigItemRepository configRepo;
        private BenefitDeductionService empCalcs;

        private const decimal expectedEmpDeduction = 1000;
        private const decimal expectedEmpDiscountedDeduction = 900;
        private const decimal expectedDepDeduction = 500;
        private const decimal expectedDepDiscountedDeduction = 450;
        private const decimal expectedPayrollDeduction = 92.31m;

        [TestInitialize]
        public void TestInitialize()
        {
            empRepo = new TestEmployeeRepository();
            configRepo = new MockConfigItemsRepository();
            empCalcs = new BenefitDeductionService(empRepo, configRepo);
        }

        [TestMethod]
        public void VerifyDeductionForEmployee()
        {
            Employee emp = empRepo.GetEmployeeById(1);

            decimal actualEmpDeduction = empCalcs.CalculateEmpCost(emp);

            Assert.AreEqual(expectedEmpDeduction, actualEmpDeduction);
        }

        [TestMethod]
        public void VerifyDiscountedDeductionForEmployee()
        {
            Employee emp = empRepo.GetEmployeeById(2);

            decimal actualEmpDiscountedDeduction = empCalcs.CalculateEmpCost(emp);

            Assert.AreEqual(expectedEmpDiscountedDeduction, actualEmpDiscountedDeduction);
        }

        [TestMethod]
        public void VerifyDeductionForDependent()
        {
            Dependent dep = empRepo.GetDependentById(3);

            decimal actualDepDeduction = empCalcs.CalculateDependentCost(dep);

            Assert.AreEqual(expectedDepDeduction, actualDepDeduction);
        }

        [TestMethod]
        public void VerifyDiscountedDeductionForDependent()
        {
            Dependent dep = empRepo.GetDependentById(1);

            decimal actualDepDiscountedDeduction = empCalcs.CalculateDependentCost(dep);

            Assert.AreEqual(expectedDepDiscountedDeduction, actualDepDiscountedDeduction);
        }

        [TestMethod]
        public void VerifyTotalPayrollDeduction()
        {
            Employee emp = empRepo.GetEmployeeById(1);

            decimal actualPayrollDeduction = Math.Round(empCalcs.CalculateEmpDeductions(emp), 2);

            Assert.AreEqual(expectedPayrollDeduction, actualPayrollDeduction);
        }
    }
}
