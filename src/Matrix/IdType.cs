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

namespace Matrix
{
    public enum IdType
    {
        /// <summary>
        /// Numeric Id's are generated by incrementing a long value
        /// </summary>
        Numeric,

        /// <summary>
        /// Guid Id's are unique, Guid packet Id's should be used for server and component applications,
        /// or apps which very long sessions (multiple days, weeks or years)
        /// </summary>
        Guid,

        /// <summary>
        /// Same as Guid, but using a base64 encoding for making them only 22 bytes long
        /// </summary>
        ShortGuid
    }
}
