﻿using System;
using System.Windows;

namespace GTA5OnlineTools.Common.Utils
{
    public class MsgBoxUtil
    {
        /// <summary>
        /// 通用信息弹窗
        /// </summary>
        public static void InformationMsgBox(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// 通用警告弹窗
        /// </summary>
        public static void WarningMsgBox(string msg)
        {
            MessageBox.Show(msg, "警告", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// 通用异常弹窗
        /// </summary>
        public static void ExceptionMsgBox(Exception ex)
        {
            MessageBox.Show("发生了未知的错误，查看错误提示以获取更多信息\n\n" +
                "错误信息 : \n" + ex.Message,
                "错误", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
