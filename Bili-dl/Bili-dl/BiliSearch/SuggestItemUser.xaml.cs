﻿using Bili;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BiliSearch
{
    /// <summary>
    /// UserSuggestItem.xaml 的交互逻辑
    /// Author: Xuan525
    /// Date: 24/04/2019
    /// </summary>
    public partial class SuggestItemUser : UserControl
    {
        public SuggestItemUser(SearchBox.UserSuggest userSuggest)
        {
            InitializeComponent();

            if (TitleInline.Text != null)
                TitleInline.Text = userSuggest.Title;

            FansInline.Text = string.Format("{0:0}Fans", BiliApi.FormatNum(userSuggest.Fans, 1)).PadRight(10, ' ');

            ArchivesInline.Text = string.Format("{0:0}Videos", BiliApi.FormatNum(userSuggest.Archives, 1));

            ImageBox.Source = new BitmapImage(new Uri(userSuggest.Cover));
        }
    }
}
