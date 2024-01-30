using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using SignaRDataAccessLayer.Concrete;
using SignaRDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaRDataAccessLayer.EntityFramework
{
	public class EFNotificationDal : GenericRepostiory<Notification>, INotificationDal
	{
		public EFNotificationDal(SignalRContext context) : base(context)
		{
		}

		public List<Notification> GetAllNotificationByFalse()
		{
			using var context = new SignalRContext();
			return context.Notifications.Where(x => x.Status == false).ToList();
		}

		public int NotificationCountByStatusFalse()
		{
			using var context = new SignalRContext();
			return context.Notifications.Where(x => x.Status == false).Count();
		}

		public void NotificationStatusChangeToFalse(int id)
		{
			using var context = new SignalRContext();
			var value = context.Notifications.Find(id);
			value.Status = false;
			context.SaveChanges();
		}

		public void NotificationStatusChangeToTrue(int id)
		{
			using var context = new SignalRContext();
			var value = context.Notifications.Find(id);
			value.Status = true;
			context.SaveChanges();
		}
	}
}
