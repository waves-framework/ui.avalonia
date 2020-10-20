﻿using System.ComponentModel;
using System.Threading.Tasks;
using Avalonia.Controls;
using Waves.Core.Base;
using Waves.Core.Base.Enums;
using Waves.UI.Avalonia.Services;
using Waves.UI.Modality.Presentation.Controllers;
using Waves.UI.Services.Interfaces;

using Application = Avalonia.Application;

namespace Waves.UI.Avalonia
{
    /// <summary>
    ///     UI Core.
    /// </summary>
    public class Core : UI.Core
    {
        /// <summary>
        ///     Gets instance of attached application.
        /// </summary>
        public Application Application { get; private set; }

        /// <summary>
        /// Gets instance of main window.
        /// </summary>
        public Window MainWindow { get; private set; }

        /// <summary>
        ///     Starts UI core.
        /// </summary>
        /// <param name="application">Application instance.</param>
        /// <param name="mainWindow">Instance of main window.</param>
        public void Start(Application application, Window mainWindow)
        {
            Application = application;
            MainWindow = mainWindow;
            
            // Application.DispatcherUnhandledException += OnDispatcherUnhandledException;
            // TaskScheduler.UnobservedTaskException += OnTaskSchedulerUnobservedTaskException;

            Start();
        }

        /// <summary>
        ///     Attaches main window.
        /// </summary>
        public void AttachMainWindow(Window window)
        {
            // Application.MainWindow = window;
            //
            // if (!(Application.MainWindow?.Content is Grid grid)) return;
            //
            // ModalWindowController = new ModalWindowsPresentationController();
            // var controllerView = new ModalWindowPresentationControllerView {DataContext = ModalWindowController };
            //
            // ModalWindowController.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            // {
            //     if (args.PropertyName == "IsVisible")
            //     {
            //         grid.Children[0].IsEnabled = !ModalWindowController.IsVisible;
            //     }
            // };
            //
            // ModalWindowController.Initialize();
            //
            // grid.Children.Add(controllerView);
        }

        /// <summary>
        ///     Initializes UI Core.
        /// </summary>
        protected override void Initialize()
        {
            InitializeServices();
        }

        /// <summary>
        ///     Initializes UI core base services.
        /// </summary>
        private void InitializeServices()
        {
            InitializeThemeService();
        }

        /// <summary>
        ///     Initializes theme service.
        /// </summary>
        private void InitializeThemeService()
        {
            var service = GetInstance<IThemeService>() as ThemeService;

            if (service == null)
                WriteLog(
                    new Message("Service", "Theme service is not initialized.", "UI Core", MessageType.Fatal));
            else
                service.AttachWindow(MainWindow);
        }

        // /// <summary>
        // ///     Notifies when unhandled exception received.
        // /// </summary>
        // /// <param name="sender">Sender.</param>
        // /// <param name="e">Arguments.</param>
        // private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        // {
        //     WriteLogMessage(new Message(e.Exception, true));
        // }
        //
        // /// <summary>
        // ///     Notifies when unhandled exception received.
        // /// </summary>
        // /// <param name="sender">Sender.</param>
        // /// <param name="e">Arguments.</param>
        // private void OnTaskSchedulerUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        // {
        //     WriteLogMessage(new Message(e.Exception, true));
        // }
    }
}