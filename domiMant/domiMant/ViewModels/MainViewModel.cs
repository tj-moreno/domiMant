
namespace domiMant.ViewModels
{
    using System;

    public class MainViewModel
    {
        #region Constructor
        public MainViewModel()
        {
            Instance = this;
            //this.Login= new LoginViewModel
            //Aqui se especifican las Viewmodel que se enlazaran a cada page
        }
        #endregion

        #region Singelton
        private static MainViewModel Instance;

        public static MainViewModel GetInstance()
        {
            if (Instance==null)
            {
                return new MainViewModel();
            }

            return Instance;
        }
        #endregion
    } 
}
