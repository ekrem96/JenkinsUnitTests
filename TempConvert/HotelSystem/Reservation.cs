using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
	public class Reservation
	{
		public User madeBy { get; private set; }

		public Reservation(User madeBy)
		{
			this.madeBy = madeBy;
		}

		public bool CanBeCanceledBy( User user)
		{
			if (user.isAdmin) return true;
			if (this.madeBy == user) return true;
			return false;
		}
	}
}
