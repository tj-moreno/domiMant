
namespace domiMant.Infraestructure
{
    using System;
    using domiMant.ViewModels;

    public class Infra
    {
        public MainViewModel Main{
            get;
            set;
        }

        public Infra()
        {
            Main = new MainViewModel();
        }
    }
}
