﻿using System;
using System.Globalization;
using MoneyFox.Business.Helpers;
using MoneyFox.Foundation.Resources;
using MvvmCross.Commands;

namespace MoneyFox.Business.ViewModels.DesignTime
{
    public class DesignTimeSelectDateRangeDialogViewModel : ISelectDateRangeDialogViewModel
    {
        public DesignTimeSelectDateRangeDialogViewModel()
        {
            Resources = new LocalizedResources(typeof(Strings), CultureInfo.CurrentUICulture);
        }

        public LocalizedResources Resources { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MvxCommand DoneCommand { get; set; }
    }
}
