﻿using NewProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NewProject
{
    public class WindowViewModel :BaseViewModel
    {
        #region Private member

        private Window mWindow;

        #endregion

        #region public Properties

        /// <summary>
        /// the current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #endregion

        #region Constructor
        public WindowViewModel(Window window)
        {
            mWindow = window;
        }
        #endregion

    }
}