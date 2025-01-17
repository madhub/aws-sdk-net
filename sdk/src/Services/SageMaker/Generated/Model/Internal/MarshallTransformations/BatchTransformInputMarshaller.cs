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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchTransformInput Marshaller
    /// </summary>
    public class BatchTransformInputMarshaller : IRequestMarshaller<BatchTransformInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchTransformInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataCapturedDestinationS3Uri())
            {
                context.Writer.WritePropertyName("DataCapturedDestinationS3Uri");
                context.Writer.Write(requestObject.DataCapturedDestinationS3Uri);
            }

            if(requestObject.IsSetDatasetFormat())
            {
                context.Writer.WritePropertyName("DatasetFormat");
                context.Writer.WriteObjectStart();

                var marshaller = MonitoringDatasetFormatMarshaller.Instance;
                marshaller.Marshall(requestObject.DatasetFormat, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndTimeOffset())
            {
                context.Writer.WritePropertyName("EndTimeOffset");
                context.Writer.Write(requestObject.EndTimeOffset);
            }

            if(requestObject.IsSetFeaturesAttribute())
            {
                context.Writer.WritePropertyName("FeaturesAttribute");
                context.Writer.Write(requestObject.FeaturesAttribute);
            }

            if(requestObject.IsSetInferenceAttribute())
            {
                context.Writer.WritePropertyName("InferenceAttribute");
                context.Writer.Write(requestObject.InferenceAttribute);
            }

            if(requestObject.IsSetLocalPath())
            {
                context.Writer.WritePropertyName("LocalPath");
                context.Writer.Write(requestObject.LocalPath);
            }

            if(requestObject.IsSetProbabilityAttribute())
            {
                context.Writer.WritePropertyName("ProbabilityAttribute");
                context.Writer.Write(requestObject.ProbabilityAttribute);
            }

            if(requestObject.IsSetProbabilityThresholdAttribute())
            {
                context.Writer.WritePropertyName("ProbabilityThresholdAttribute");
                context.Writer.Write(requestObject.ProbabilityThresholdAttribute);
            }

            if(requestObject.IsSetS3DataDistributionType())
            {
                context.Writer.WritePropertyName("S3DataDistributionType");
                context.Writer.Write(requestObject.S3DataDistributionType);
            }

            if(requestObject.IsSetS3InputMode())
            {
                context.Writer.WritePropertyName("S3InputMode");
                context.Writer.Write(requestObject.S3InputMode);
            }

            if(requestObject.IsSetStartTimeOffset())
            {
                context.Writer.WritePropertyName("StartTimeOffset");
                context.Writer.Write(requestObject.StartTimeOffset);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchTransformInputMarshaller Instance = new BatchTransformInputMarshaller();

    }
}