// jQueryTemplateInstance.cs
// Script#/Libraries/jQuery/jQueryTemplating
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Collections;
using System.Html;
using System.Net;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace jQueryApi.Templating {

    /// <summary>
    /// Represents an instantiated jQuery template.
    /// </summary>
    [IgnoreNamespace]
    [Imported]
    public sealed class jQueryTemplateInstance {

        private jQueryTemplateInstance() {
        }

        /// <summary>
        /// Gets the data that this instance is based on.
        /// </summary>
        [IntrinsicProperty]
        public object Data {
            get {
                return null;
            }
        }

        /// <summary>
        /// Gets the elements that this template instance represents.
        /// </summary>
        [IntrinsicProperty]
        public Element[] Nodes {
            get {
                return null;
            }
        }

        /// <summary>
        /// Gets or sets the template that this instance is based on.
        /// </summary>
        [IntrinsicProperty]
        public jQueryTemplate Template {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Updates the rendering once an update template has been set.
        /// </summary>
        public void Update() {
        }
    }
}
