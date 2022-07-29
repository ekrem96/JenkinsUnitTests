using HotelSystem;

namespace HotelUnitTests
{
	[TestClass]
	public class ReservationTests
	{
		[TestMethod]
		public void ShouldBeCanceledByAdmin()
		{
			//arrange
			User user = new User(true);
			Reservation reservation = new Reservation(user);

			//act
			bool result = reservation.CanBeCanceledBy(user);

			//assert
			Assert.IsTrue(result);

		}

		[TestMethod]
		public void ShouldBeCanceledBySameUser()
		{
			User user = new User(false);
			Reservation reserVation = new Reservation(user);

			bool result = reserVation.CanBeCanceledBy(user);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void ShoudNotBeCanceledByOtherUser()
		{
			User userOne = new User(false);
			User userTwo = new User(false);
			Reservation reservation = new Reservation(userOne);

			bool result = reservation.CanBeCanceledBy(userTwo);

			Assert.IsFalse(result);
		}
	}
}