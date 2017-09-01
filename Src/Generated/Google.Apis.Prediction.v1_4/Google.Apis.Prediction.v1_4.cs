// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.29.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Prediction API Version v1.4
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/prediction/docs/developer-guide'>Prediction API</a>
 *      <tr><th>API Version<td>v1.4
 *      <tr><th>API Rev<td>20160511 (496)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/prediction/docs/developer-guide'>
 *              https://developers.google.com/prediction/docs/developer-guide</a>
 *      <tr><th>Discovery Name<td>prediction
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Prediction API can be found at
 * <a href='https://developers.google.com/prediction/docs/developer-guide'>https://developers.google.com/prediction/docs/developer-guide</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Prediction.v1_4
{
    /// <summary>The Prediction Service.</summary>
    public class PredictionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1.4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PredictionService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PredictionService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            hostedmodels = new HostedmodelsResource(this);
            trainedmodels = new TrainedmodelsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "prediction"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/prediction/v1.4/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "prediction/v1.4/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Prediction API.</summary>
        public class Scope
        {
            /// <summary>Manage your data and permissions in Google Cloud Storage</summary>
            public static string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public static string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Google Cloud Storage</summary>
            public static string DevstorageReadWrite = "https://www.googleapis.com/auth/devstorage.read_write";

            /// <summary>Manage your data in the Google Prediction API</summary>
            public static string Prediction = "https://www.googleapis.com/auth/prediction";

        }



        private readonly HostedmodelsResource hostedmodels;

        /// <summary>Gets the Hostedmodels resource.</summary>
        public virtual HostedmodelsResource Hostedmodels
        {
            get { return hostedmodels; }
        }

        private readonly TrainedmodelsResource trainedmodels;

        /// <summary>Gets the Trainedmodels resource.</summary>
        public virtual TrainedmodelsResource Trainedmodels
        {
            get { return trainedmodels; }
        }
    }

    ///<summary>A base abstract class for Prediction requests.</summary>
    public abstract class PredictionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new PredictionBaseServiceRequest instance.</summary>
        protected PredictionBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Prediction parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "hostedmodels" collection of methods.</summary>
    public class HostedmodelsResource
    {
        private const string Resource = "hostedmodels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public HostedmodelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Submit input and request an output against a hosted model.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="hostedModelName">The name of a hosted model.</param>
        public virtual PredictRequest Predict(Google.Apis.Prediction.v1_4.Data.Input body, string hostedModelName)
        {
            return new PredictRequest(service, body, hostedModelName);
        }

        /// <summary>Submit input and request an output against a hosted model.</summary>
        public class PredictRequest : PredictionBaseServiceRequest<Google.Apis.Prediction.v1_4.Data.Output>
        {
            /// <summary>Constructs a new Predict request.</summary>
            public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.Prediction.v1_4.Data.Input body, string hostedModelName)
                : base(service)
            {
                HostedModelName = hostedModelName;
                Body = body;
                InitParameters();
            }


            /// <summary>The name of a hosted model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("hostedModelName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string HostedModelName { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Prediction.v1_4.Data.Input Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "predict"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "hostedmodels/{hostedModelName}/predict"; }
            }

            /// <summary>Initializes Predict parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "hostedModelName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "hostedModelName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "trainedmodels" collection of methods.</summary>
    public class TrainedmodelsResource
    {
        private const string Resource = "trainedmodels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TrainedmodelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Delete a trained model.</summary>
        /// <param name="id">The unique name for the predictive model.</param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Delete a trained model.</summary>
        public class DeleteRequest : PredictionBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id)
                : base(service)
            {
                Id = id;
                InitParameters();
            }


            /// <summary>The unique name for the predictive model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "delete"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "DELETE"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "trainedmodels/{id}"; }
            }

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Check training status of your model.</summary>
        /// <param name="id">The unique name for the predictive model.</param>
        public virtual GetRequest Get(string id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>Check training status of your model.</summary>
        public class GetRequest : PredictionBaseServiceRequest<Google.Apis.Prediction.v1_4.Data.Training>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string id)
                : base(service)
            {
                Id = id;
                InitParameters();
            }


            /// <summary>The unique name for the predictive model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "trainedmodels/{id}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Begin training your model.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Prediction.v1_4.Data.Training body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Begin training your model.</summary>
        public class InsertRequest : PredictionBaseServiceRequest<Google.Apis.Prediction.v1_4.Data.Training>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Prediction.v1_4.Data.Training body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Prediction.v1_4.Data.Training Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "insert"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "trainedmodels"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Submit model id and request a prediction</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The unique name for the predictive model.</param>
        public virtual PredictRequest Predict(Google.Apis.Prediction.v1_4.Data.Input body, string id)
        {
            return new PredictRequest(service, body, id);
        }

        /// <summary>Submit model id and request a prediction</summary>
        public class PredictRequest : PredictionBaseServiceRequest<Google.Apis.Prediction.v1_4.Data.Output>
        {
            /// <summary>Constructs a new Predict request.</summary>
            public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.Prediction.v1_4.Data.Input body, string id)
                : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique name for the predictive model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Prediction.v1_4.Data.Input Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "predict"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "trainedmodels/{id}/predict"; }
            }

            /// <summary>Initializes Predict parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Add new data to a trained model.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The unique name for the predictive model.</param>
        public virtual UpdateRequest Update(Google.Apis.Prediction.v1_4.Data.Update body, string id)
        {
            return new UpdateRequest(service, body, id);
        }

        /// <summary>Add new data to a trained model.</summary>
        public class UpdateRequest : PredictionBaseServiceRequest<Google.Apis.Prediction.v1_4.Data.Training>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Prediction.v1_4.Data.Update body, string id)
                : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique name for the predictive model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Prediction.v1_4.Data.Update Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "update"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PUT"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "trainedmodels/{id}"; }
            }

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Prediction.v1_4.Data
{    

    public class Input : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input to the model for a prediction</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual Input.InputData InputValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>Input to the model for a prediction</summary>
        public class InputData
        {
            /// <summary>A list of input features, these can be strings or doubles.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("csvInstance")]
            public virtual System.Collections.Generic.IList<object> CsvInstance { get; set; } 

        }
    }    

    public class Output : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique name for the predictive model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>What kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The most likely class label [Categorical models only].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputLabel")]
        public virtual string OutputLabel { get; set; } 

        /// <summary>A list of class labels with their estimated probabilities [Categorical models only].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputMulti")]
        public virtual System.Collections.Generic.IList<Output.OutputMultiData> OutputMulti { get; set; } 

        /// <summary>The estimated regression value [Regression models only].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputValue")]
        public virtual System.Nullable<double> OutputValue { get; set; } 

        /// <summary>A URL to re-request this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class OutputMultiData
        {
            /// <summary>The class label.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("label")]
            public virtual string Label { get; set; } 

            /// <summary>The probability of the class label.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("score")]
            public virtual System.Nullable<double> Score { get; set; } 

        }
    }    

    public class Training : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data Analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAnalysis")]
        public virtual Training.DataAnalysisData DataAnalysis { get; set; } 

        /// <summary>The unique name for the predictive model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>What kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Model metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelInfo")]
        public virtual Training.ModelInfoData ModelInfo { get; set; } 

        /// <summary>A URL to re-request this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>Google storage location of the training data file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageDataLocation")]
        public virtual string StorageDataLocation { get; set; } 

        /// <summary>Google storage location of the preprocessing pmml file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePMMLLocation")]
        public virtual string StoragePMMLLocation { get; set; } 

        /// <summary>Google storage location of the pmml model file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePMMLModelLocation")]
        public virtual string StoragePMMLModelLocation { get; set; } 

        /// <summary>The current status of the training job. This can be one of following: RUNNING; DONE; ERROR; ERROR:
        /// TRAINING JOB NOT FOUND</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStatus")]
        public virtual string TrainingStatus { get; set; } 

        /// <summary>A class weighting function, which allows the importance weights for class labels to be specified
        /// [Categorical models only].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utility")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,System.Nullable<double>>> Utility { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>Data Analysis.</summary>
        public class DataAnalysisData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
            public virtual System.Collections.Generic.IList<string> Warnings { get; set; } 

        }    

        /// <summary>Model metadata.</summary>
        public class ModelInfoData
        {
            /// <summary>Estimated accuracy of model taking utility weights into account [Categorical models
            /// only].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("classWeightedAccuracy")]
            public virtual System.Nullable<double> ClassWeightedAccuracy { get; set; } 

            /// <summary>A number between 0.0 and 1.0, where 1.0 is 100% accurate. This is an estimate, based on the
            /// amount and quality of the training data, of the estimated prediction accuracy. You can use this is a
            /// guide to decide whether the results are accurate enough for your needs. This estimate will be more
            /// reliable if your real input data is similar to your training data [Categorical models only].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("classificationAccuracy")]
            public virtual System.Nullable<double> ClassificationAccuracy { get; set; } 

            /// <summary>An output confusion matrix. This shows an estimate for how this model will do in predictions.
            /// This is first indexed by the true class label. For each true class label, this provides a pair
            /// {predicted_label, count}, where count is the estimated number of times the model will predict the
            /// predicted label given the true label. Will not output if more then 100 classes [Categorical models
            /// only].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrix")]
            public virtual System.Collections.Generic.IDictionary<string,System.Collections.Generic.IDictionary<string,System.Nullable<double>>> ConfusionMatrix { get; set; } 

            /// <summary>A list of the confusion matrix row totals</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrixRowTotals")]
            public virtual System.Collections.Generic.IDictionary<string,System.Nullable<double>> ConfusionMatrixRowTotals { get; set; } 

            /// <summary>An estimated mean squared error. The can be used to measure the quality of the predicted model
            /// [Regression models only].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredError")]
            public virtual System.Nullable<double> MeanSquaredError { get; set; } 

            /// <summary>Type of predictive model (CLASSIFICATION or REGRESSION)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
            public virtual string ModelType { get; set; } 

            /// <summary>Number of valid data instances used in the trained model.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberInstances")]
            public virtual System.Nullable<long> NumberInstances { get; set; } 

            /// <summary>Number of class labels in the trained model [Categorical models only].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberLabels")]
            public virtual System.Nullable<long> NumberLabels { get; set; } 

        }
    }    

    public class Update : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The input features for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvInstance")]
        public virtual System.Collections.Generic.IList<object> CsvInstance { get; set; } 

        /// <summary>The class label of this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; } 

        /// <summary>The generic output value - could be regression value or class label</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual string Output { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
