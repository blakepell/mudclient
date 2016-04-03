﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectedMonsterParameter.cs" company="Adamand MUD">
//   Copyright (c) Adamant MUD
// </copyright>
// <summary>
//   Defines the SelectedMonsterParameter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Adan.Client.Plugins.GroupWidget.Model.ActionParameters
{
    using System;
    using System.Collections.Generic;

    using Common.Model;

    using CSLib.Net.Diagnostics;

    /// <summary>
    /// A parameter that return a name of selected group mate.
    /// </summary>
    [Serializable]
    public class SelectedMonsterParameter : ActionParameterBase
    {
        /// <summary>
        /// Gets the parameter value.
        /// </summary>
        /// <param name="rootModel">The root model.</param>
        /// <param name="context">The context.</param>
        /// <returns>
        /// Parameter value.
        /// </returns>
        public override string GetParameterValue(RootModel rootModel, ActionExecutionContext context)
        {
            Assert.ArgumentNotNull(rootModel, "rootModel");
            Assert.ArgumentNotNull(context, "context");
            if (rootModel.SelectedRoomMonster == null)
            {
                return string.Empty;
            }

            return rootModel.SelectedRoomMonster.TargetName.Replace(' ', '.');
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GetParameterValue()
        {
            return "#SelectedMonsterName";
        }
    }
}