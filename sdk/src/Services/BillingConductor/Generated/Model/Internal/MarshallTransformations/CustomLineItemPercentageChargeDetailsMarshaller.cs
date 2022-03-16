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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomLineItemPercentageChargeDetails Marshaller
    /// </summary>
    public class CustomLineItemPercentageChargeDetailsMarshaller : IRequestMarshaller<CustomLineItemPercentageChargeDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomLineItemPercentageChargeDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociatedValues())
            {
                context.Writer.WritePropertyName("AssociatedValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssociatedValuesListValue in requestObject.AssociatedValues)
                {
                        context.Writer.Write(requestObjectAssociatedValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPercentageValue())
            {
                context.Writer.WritePropertyName("PercentageValue");
                context.Writer.Write(requestObject.PercentageValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomLineItemPercentageChargeDetailsMarshaller Instance = new CustomLineItemPercentageChargeDetailsMarshaller();

    }
}