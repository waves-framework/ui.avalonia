﻿using System;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using Waves.Core.Base.Interfaces;
using Waves.Presentation.Interfaces;

namespace Waves.UI.Avalonia.Showcase.View.Control.Tabs
{
    /// <summary>
    /// ComboBox tab view.
    /// </summary>
    public class ComboBoxesTabView : UserControl, IPresenterView
    {
        /// <summary>
        /// Creates new instance of <see cref="ComboBoxesTabView"/>.
        /// </summary>
        public ComboBoxesTabView()
        {
            InitializeComponent();
        }

        /// <inheritdoc />
        public Guid Id { get; } = Guid.NewGuid();

        /// <inheritdoc />
        public event EventHandler<IMessage> MessageReceived;

        /// <summary>
        /// Notifies when message received.
        /// </summary>
        /// <param name="e">Message.</param>
        protected virtual void OnMessageReceived(IMessage e)
        {
            MessageReceived?.Invoke(this, e);
        }
        
        /// <summary>
        /// Initializes components.
        /// </summary>
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}