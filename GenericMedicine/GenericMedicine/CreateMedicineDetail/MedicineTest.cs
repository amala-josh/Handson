using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMedicineDetail
{
    [TestFixture]
    public class MedicineTest
    {
        
            [Test]
            [TestCase("XYZ", "Crocin", "Composition1", "2022/6/3", 12)]
            [TestCase("ABC", "Claven", "Composition2", "2023/11/13", 11.9)]
            
            public void CreateMedicineDetail_WhenCalled_CreateAndReturnMedicineObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
            {
                Program p = new Program();
                Medicine result = p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

                Assert.That(result.Name, Is.EqualTo(name));
                Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
                Assert.That(result.Composition, Is.EqualTo(composition));
                Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
                Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));
            }
        //Medicine Name Empty or NULL
            [Test]
            [TestCase("Name1", "", "Comp1", "2022/6/3", 12)]
            [TestCase("Name2", null, "Comp2", "2023/11/13", 11.9)]
            //[TestCase("XYZ", "Crocin", "Composition1", "2022/6/3", 12)]
            public void CreateMedicineDetail_WhenCalledWithEmptyGenericMedicineName_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
            {
                Program p = new Program();

                var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
                Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exception.Message);
            }

            [Test]
            [TestCase("I1", "Crocin", "C3", "2022/3/7", -12)]
            //[TestCase("I2", "Anacin", "C4", "2023/11/13", 11.9)]
            public void CreateMedicineDetail_WhenCalledPriceLessThanZero_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
            {
                Program pm = new Program();

                var exception = Assert.Throws<Exception>(() => pm.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
                Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
            }

            [Test]
            [TestCase("AWS", "Calco", "C6", "2019/3/7", 12)]
            //[TestCase("MMM", "Syrup", "C7", "2022/11/13", 11.9)]
            public void CreateMedicineDetail_WhenCalledWithDateLessThanCurrentDate_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
            {
                Program pd = new Program();

                var exception = Assert.Throws<Exception>(() => pd.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
                Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
            }

    }
 }

