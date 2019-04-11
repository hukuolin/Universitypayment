using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureMVC.Patterns;
using PureMVC.Interfaces;
namespace ChatFactory.App
{

    public class FacadeFactory : PureMVC.Patterns.Facade.Facade
    {
        private static FacadeFactory mInstance = null;

        public static FacadeFactory XPFacadeInstance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new FacadeFactory("Facade");
                }

                return mInstance;
            }
        }
        public FacadeFactory(string key) : base(key)
        {

        }
        protected override void InitializeController()
        {
            base.InitializeController();


        }
        protected override void InitializeModel()
        {
            base.InitializeModel();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
    }
    public class CommandFactory:PureMVC.Patterns.Command.SimpleCommand
    {

        public override void Execute(INotification notification)
        {
            base.Execute(notification);
        }
        public override void SendNotification(string notificationName, object body = null, string type = null)
        {
            base.SendNotification(notificationName, body, type);
        }
    }

    public class ProxyFactory : IProxy
    {
        private string proxyName;
        private object notifyData;
        public ProxyFactory(string name)
        {
            proxyName = name;

        }
        public string ProxyName => proxyName;

        public object Data { get => notifyData; set => notifyData = value; }

        public void InitializeNotifier(string key)
        {

        }

        public void OnRegister()
        {

        }

        public void OnRemove()
        {

        }

        public void SendNotification(string notificationName, object body = null, string type = null)
        {

        }
    }

}
