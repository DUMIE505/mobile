﻿using Bit.iOS.Core.Utilities;
using System;
using UIKit;

namespace Bit.iOS.Core.Views
{
    public abstract class ExtendedUITableViewSource : UITableViewSource
    {
        public override void WillDisplayHeaderView(UITableView tableView, UIView headerView, nint section)
        {
            if(headerView != null && headerView is UITableViewHeaderFooterView hv && hv.TextLabel != null)
            {
                hv.TextLabel.TextColor = ThemeHelpers.MutedColor;
                hv.TintColor = ThemeHelpers.ListHeaderBackgroundColor;
                hv.BackgroundView.BackgroundColor = ThemeHelpers.ListHeaderBackgroundColor;
            }
        }

        public override void WillDisplayFooterView(UITableView tableView, UIView footerView, nint section)
        {
            if(footerView != null && footerView is UITableViewHeaderFooterView fv && fv.TextLabel != null)
            {
                fv.TextLabel.TextColor = ThemeHelpers.MutedColor;
                fv.TintColor = ThemeHelpers.ListHeaderBackgroundColor;
                fv.BackgroundView.BackgroundColor = ThemeHelpers.ListHeaderBackgroundColor;
            }
        }
    }
}