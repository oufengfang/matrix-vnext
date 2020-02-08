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
using Matrix.Xml;

namespace Matrix.Xmpp.Compression
{
    [XmppTag(Name = "compress", Namespace = Namespaces.Compress)]
    public class Compress : XmppXElement
    {        
        #region << Constructors >>
        public Compress() : base(Namespaces.Compress, "compress")
        {
        }

        /// <summary>
        /// Constructor with a given method/algorithm for Stream compression
        /// </summary>
        /// <param name="method">method/algorithm used to compressing the stream</param>
        public Compress(Methods method) : this()
        {
            Method = method;
        }
        #endregion

        /// <summary>
        /// method/algorithm used to compressing the stream
        /// </summary>
        public Methods Method
        {
            set 
            {
                if (value != Methods.Unknown)
					SetTag("method", value.GetName());  
            }
            get 
            {
                return GetTagEnumUsingNameAttrib<Methods>("method");
            }
        }
    }    
}
