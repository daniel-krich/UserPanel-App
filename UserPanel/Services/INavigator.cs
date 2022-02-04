﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPanel.Services
{
    public interface INavigator
    {
        object CurrentView { get; set; }
        void SetWindowTitle(string title);
    }
}
