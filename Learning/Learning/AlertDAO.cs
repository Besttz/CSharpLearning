using System.Collections.Generic;
using System;
namespace Learning
{

    public interface IAlertDAO
    {
        public Guid AddAlert(DateTime time);
        public DateTime GetAlert(Guid id);
    }
    public class AlertService
    {
        private readonly IAlertDAO storage = new AlertDAO();

        public AlertService(IAlertDAO storage)
        {
            this.storage = storage;
        }

        public Guid RaiseAlert()
        {
            return this.storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return this.storage.GetAlert(id);
        }
    }

    public class AlertDAO : IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }
}