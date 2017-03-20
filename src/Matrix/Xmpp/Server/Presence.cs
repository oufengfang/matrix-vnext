/*
 * Copyright (c) 2003-2017 by AG-Software <info@ag-software.de>
 *
 * All Rights Reserved.
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

namespace Matrix.Xmpp.Server
{
    [XmppTag(Name = Tag.Presence, Namespace = Namespaces.Server)]
    public class Presence : Base.Presence
    {
        #region <<Constructors >>
        public Presence() : base(Namespaces.Server)
        {
        }

        public Presence(Show show) : this()
        {
            Show = show;
        }

        public Presence(Show show, string status)
            : this(show)
        {
            Status = status;
        }

        public Presence(Show show, string status, int priority)
            : this(show, status)
        {
            Priority = priority;
        }
        #endregion

        /// <summary>
        /// Error object
        /// </summary>
        public Error Error
        {
            get { return Element<Error>(); }
            set { Replace<Error>(value); }
        }
    }
}
