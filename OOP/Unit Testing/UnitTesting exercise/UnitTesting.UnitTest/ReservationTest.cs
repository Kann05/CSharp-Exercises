using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;
using UnitTesting_exercise1;

namespace UnitTesting.UnitTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_Admin_ReturnsTrue()
        {
            Reservation reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation { MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserThatIsNotAdminAndNotMadeByUser_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
            
        }
    }
}
