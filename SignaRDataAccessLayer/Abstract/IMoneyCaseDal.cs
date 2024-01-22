using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaRDataAccessLayer.Abstract
{
	public interface IMoneyCaseDal : IGenericDal<MoneyCase>
	{
		decimal TotalMoneyCaseAmount();
	}
}
