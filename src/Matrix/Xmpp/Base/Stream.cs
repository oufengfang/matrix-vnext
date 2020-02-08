/*
 * Copyright (c) 2003-2020 by AG-Software <info@ag-software.de>
 *
 * All Rights Reserved.
 * See the COPYING file for more information.
 *
 * This file is part of the MatriX project.
 *
 * NOTICE: All information contained herein is, and remains the property
 * of AG-Software and its suppliers, if any.
 * The intellectual and technical concepts contained herein are proprietary
 * to AG-Software and its suppliers and may be covered by German and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 *
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained
 * from AG-Software.
 *
 * Contact information for AG-Software is available at http://www.ag-software.de
 */

using Matrix.Attributes;

namespace Matrix.Xmpp.Base
{
    /// <summary>
    /// Represents a XMPP stream header
    /// </summary>
    [XmppTag(Name = "stream", Namespace = Namespaces.Stream)]
    public class Stream : XmppXElementWithAddressAndId
    {
        #region << Constructors >>
        public Stream()
            : base(Namespaces.Stream, "stream", "stream")
        {
        }

        internal Stream(string ns, string tagname)
            : base(ns, tagname)
        {
        }
        #endregion
        
        /// <summary>
        /// See XMPP-Core 4.4.1 "Version Support"
        /// </summary>
        public string Version
        {
            get { return GetAttribute("version"); }
            set { SetAttribute("version", value); }
        }
    }
}
