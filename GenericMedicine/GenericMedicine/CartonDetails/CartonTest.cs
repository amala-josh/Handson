using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartonDetails
{
    public class CartonTest
    {
        private static Medicine GetMedicineObject(string s)
        {
            if (s.Equals("Comm"))
            {
                return new Medicine()
                {
                    Name = "Ted",
                    GenericMedicineName = "Crocin",
                    Composition = "Composition",
                    ExpiryDate = new DateTime(2024, 12, 1),
                    PricePerStrip = 30
                };
            }
            else
            {
                return null;
            }

        }
        [Test]
        [TestCase(5, "2022/11/6", "Goa", "Comm")]
        [TestCase(5, "2022/6/7", "Chennai", "Comm")]
        [TestCase(5, "2021/11/6", "Coimbatore", "Comm")]
        public void CreateCartonDetail_WhenCalled_ReturnCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program pro = new Program();

            Medicine m;
            m = GetMedicineObject(key);

            CartonDetail result = pro.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(result.MedicineStripCount, Is.EqualTo(medicineStripCount));
            Assert.That(result.LaunchDate, Is.EqualTo(launchDate));
        }

        [Test]
        [TestCase(-5, "2022/11/6", "Avadi", "Comm")]
        [TestCase(-1, "2022/6/7", "Delhi", "Comm")]
        public void CreateCartonDetail_WhenCalledWithLessThanZeroStripCount_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program pro = new Program();

            Medicine m;
            m = GetMedicineObject(key);

            var exception = Assert.Throws<Exception>(() => pro.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect strip count. Please check", exception.Message);

        }

        [Test]
        [TestCase(5, "2020/11/6", "Address1", "Comm")]
        [TestCase(1, "2021/3/7", "Address1", "Comm")]
        public void CreateCartonDetail_WhenCalledWithLaunchDateLessThanCurrentDate_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program pro = new Program();
            Medicine m;
            m = GetMedicineObject(key);

            var exception = Assert.Throws<Exception>(() => pro.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);

        }


        [Test]
        [TestCase(5, "2022/11/6", "Address1", "Empty")]
        [TestCase(5, "2022/6/7", "Address1", "Empty")]
        [TestCase(5, "2021/11/6", "Address1", "Empty")]
        public void CreateCartonDetail_WhenCalledWithEmptyMedicine_ReturnsEmptyCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program pro = new Program();

            Medicine m;
            m = GetMedicineObject(key);

            CartonDetail result = pro.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(result, Is.EqualTo(null));

        }

    }
}

