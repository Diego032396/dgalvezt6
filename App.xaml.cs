﻿namespace dgalvezt6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.vInicio());
        }
    }
}
