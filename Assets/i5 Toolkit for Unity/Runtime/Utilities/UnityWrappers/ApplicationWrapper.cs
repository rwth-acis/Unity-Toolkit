﻿using System;
using UnityEngine;

namespace i5.Toolkit.Core.Utilities.UnityAdapters
{
    /// <summary>
    /// Wrapper for Unity's <see cref="Application"/>
    /// </summary>
    public class ApplicationWrapper : IApplication
    {
        /// <summary>
        /// Connects to Application.absoluteURL
        /// </summary>
        public string AbsoluteURL => Application.absoluteURL;

        /// <summary>
        /// Connects to Application.deepLinkActivated
        /// </summary>
        public event EventHandler<string> DeepLinkActivated;

        /// <summary>
        /// Creates a new instance of the ApplicationWrapper
        /// </summary>
        public ApplicationWrapper()
        {
            Application.deepLinkActivated += OnDeepLinkActivated;
        }

        /// <summary>
        /// Called if the <see cref="Application.deepLinkActivated"/> event was raised
        /// </summary>
        /// <param name="obj"></param>
        private void OnDeepLinkActivated(string obj)
        {
            DeepLinkActivated?.Invoke(null, obj);
        }
    }
}
