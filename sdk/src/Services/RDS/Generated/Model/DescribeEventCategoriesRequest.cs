/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventCategories operation.
    /// Displays a list of categories for all event source types, or, if specified, for a
    /// specified source type. You can also see this list in the "Amazon RDS event categories
    /// and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
    /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
    /// <i>Amazon Aurora User Guide</i> </a>.
    /// </summary>
    public partial class DescribeEventCategoriesRequest : AmazonRDSRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private string _sourceType;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter isn't currently supported.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source that is generating the events. For RDS Proxy events, specify <code>db-proxy</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>db-instance</code> | <code>db-cluster</code> | <code>db-parameter-group</code>
        /// | <code>db-security-group</code> | <code>db-snapshot</code> | <code>db-cluster-snapshot</code>
        /// | <code>db-proxy</code> 
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}