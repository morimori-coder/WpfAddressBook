using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfAddressBook
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        // Startupで呼ばれるイベントハンドラ
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // アプリ開始時の処理

            // アプリケーションで発生した未処理の例外の処理
            AppDomain.CurrentDomain.UnhandledException += (o, eh) =>
            {
                // 例外の処理
                var _ex = eh.ExceptionObject as Exception;
                MessageBox.Show(_ex.ToString());

                // このまま終わると動作を停止しましたというウインドウが出てしまうので
                // 挙動を抑えるために自分で先んじで終了する
                Environment.Exit(-1);
            };
        }

        // DispatcherUnhandledExceptionのイベントハンドラ
        private void Application_DispatcherUnhandledException(object sender,
            DispatcherUnhandledExceptionEventArgs e)
        {
            // 未処理の例外の処理
            Exception ex = e.Exception;
            MessageBox.Show(ex.ToString());

            // ハンドルされない例外を処理済みにするためにtrueを指定
            e.Handled = true;
        }
    }
}
