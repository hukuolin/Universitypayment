using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PureMVC.Interfaces;
namespace ChatFactory.App
{
    public partial class DockContenMediator : Form, IMediator, INotifier
    {
        public DockContenMediator() : this("")
        {

        }
        public DockContenMediator(string name)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        #region Constants

        #endregion

        #region Members

        protected string mediatorName;
        protected object compontent;
        #endregion

        #region Constructors

        


        #endregion

        #region Accessors

        public virtual string MediatorName
        {
            get { return mediatorName; }
        }


        public virtual object ViewComponent
        {
            get { return compontent; }
            set { compontent = value; }
        }


        protected IFacade Facade
        {
            get { return m_facade; }
        }
        #endregion

        #region Private Members


        private IFacade m_facade = FacadeFactory.XPFacadeInstance;

        #endregion

        #region Public Methods
        #region IMediator Members

        public virtual string[] ListNotificationInterests()
        {
            return new string[] { };
        }


        public virtual void HandleNotification(INotification notification)
        {
        }


        public virtual void OnRegister()
        {
        }


        public virtual void OnRemove()
        {
        }
        #endregion

        #region INotifier Members




        public virtual void SendNotification(string notificationName, object body, string type)
        {

            m_facade.SendNotification(notificationName, body, type);
        }
        public virtual void InitializeNotifier(string key)
        {

        }
        #endregion
        #endregion
    }
}
