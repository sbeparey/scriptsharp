// FeedFolderCollection.cs
// Script#/Libraries/Windows
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Windows.Feeds {

    [IgnoreNamespace]
    [Imported]
    public sealed class FeedFolderCollection {

        private FeedFolderCollection() {
        }

        [IntrinsicProperty]
        public int Count {
            get {
                return 0;
            }
        }

        public FeedFolder Item(int index) {
            return null;
        }
    }
}
