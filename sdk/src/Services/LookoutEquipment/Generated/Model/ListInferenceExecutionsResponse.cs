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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListInferenceExecutions operation.
    /// </summary>
    public partial class ListInferenceExecutionsResponse : AmazonWebServiceResponse
    {
        private List<InferenceExecutionSummary> _inferenceExecutionSummaries = new List<InferenceExecutionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InferenceExecutionSummaries. 
        /// <para>
        /// Provides an array of information about the individual inference executions returned
        /// from the <code>ListInferenceExecutions</code> operation, including model used, inference
        /// scheduler, data configuration, and so on. 
        /// </para>
        /// </summary>
        public List<InferenceExecutionSummary> InferenceExecutionSummaries
        {
            get { return this._inferenceExecutionSummaries; }
            set { this._inferenceExecutionSummaries = value; }
        }

        // Check to see if InferenceExecutionSummaries property is set
        internal bool IsSetInferenceExecutionSummaries()
        {
            return this._inferenceExecutionSummaries != null && this._inferenceExecutionSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of inference
        /// executions. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}