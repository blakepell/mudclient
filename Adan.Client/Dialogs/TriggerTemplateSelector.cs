﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TriggerTemplateSelector.cs" company="Adamand MUD">
//   Copyright (c) Adamant MUD
// </copyright>
// <summary>
//   Defines the TriggerTemplateSelector type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Adan.Client.Dialogs
{
    using System.Windows;
    using System.Windows.Controls;

    using CSLib.Net.Annotations;

    /// <summary>
    /// Trigger template selector.
    /// </summary>
    public class TriggerTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// When overridden in a derived class, returns a <see cref="T:System.Windows.DataTemplate"/> based on custom logic.
        /// </summary>
        /// <param name="item">The data object for which to select the template.</param>
        /// <param name="container">The data-bound object.</param>
        /// <returns>
        /// Returns a <see cref="T:System.Windows.DataTemplate"/> or null. The default value is null.
        /// </returns>
        public override DataTemplate SelectTemplate([CanBeNull] object item, [CanBeNull] DependencyObject container)
        {
            var element = container as FrameworkElement;

            if (element != null && item != null)
            {
                return element.FindResource(item.GetType().Name + "Template") as DataTemplate;
            }

            return null;
        }
    }
}
