// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallAutomation
{
    internal partial class AzureCommunicationServicesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AzureCommunicationServicesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public AzureCommunicationServicesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2023-10-03-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateCallRequest(CreateCallRequestInternal createCallRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createCallRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Create an outbound call. </summary>
        /// <param name="createCallRequest"> The create call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createCallRequest"/> is null. </exception>
        public async Task<Response<CallConnectionPropertiesInternal>> CreateCallAsync(CreateCallRequestInternal createCallRequest, CancellationToken cancellationToken = default)
        {
            if (createCallRequest == null)
            {
                throw new ArgumentNullException(nameof(createCallRequest));
            }

            using var message = CreateCreateCallRequest(createCallRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create an outbound call. </summary>
        /// <param name="createCallRequest"> The create call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createCallRequest"/> is null. </exception>
        public Response<CallConnectionPropertiesInternal> CreateCall(CreateCallRequestInternal createCallRequest, CancellationToken cancellationToken = default)
        {
            if (createCallRequest == null)
            {
                throw new ArgumentNullException(nameof(createCallRequest));
            }

            using var message = CreateCreateCallRequest(createCallRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnswerCallRequest(AnswerCallRequestInternal answerCallRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:answer", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(answerCallRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Answer a Call. </summary>
        /// <param name="answerCallRequest"> The answer call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="answerCallRequest"/> is null. </exception>
        /// <remarks> Answer a call using the IncomingCallContext from Event Grid. </remarks>
        public async Task<Response<CallConnectionPropertiesInternal>> AnswerCallAsync(AnswerCallRequestInternal answerCallRequest, CancellationToken cancellationToken = default)
        {
            if (answerCallRequest == null)
            {
                throw new ArgumentNullException(nameof(answerCallRequest));
            }

            using var message = CreateAnswerCallRequest(answerCallRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Answer a Call. </summary>
        /// <param name="answerCallRequest"> The answer call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="answerCallRequest"/> is null. </exception>
        /// <remarks> Answer a call using the IncomingCallContext from Event Grid. </remarks>
        public Response<CallConnectionPropertiesInternal> AnswerCall(AnswerCallRequestInternal answerCallRequest, CancellationToken cancellationToken = default)
        {
            if (answerCallRequest == null)
            {
                throw new ArgumentNullException(nameof(answerCallRequest));
            }

            using var message = CreateAnswerCallRequest(answerCallRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRedirectCallRequest(RedirectCallRequestInternal redirectCallRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:redirect", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(redirectCallRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Redirect a call. </summary>
        /// <param name="redirectCallRequest"> The redirect call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="redirectCallRequest"/> is null. </exception>
        public async Task<Response> RedirectCallAsync(RedirectCallRequestInternal redirectCallRequest, CancellationToken cancellationToken = default)
        {
            if (redirectCallRequest == null)
            {
                throw new ArgumentNullException(nameof(redirectCallRequest));
            }

            using var message = CreateRedirectCallRequest(redirectCallRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Redirect a call. </summary>
        /// <param name="redirectCallRequest"> The redirect call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="redirectCallRequest"/> is null. </exception>
        public Response RedirectCall(RedirectCallRequestInternal redirectCallRequest, CancellationToken cancellationToken = default)
        {
            if (redirectCallRequest == null)
            {
                throw new ArgumentNullException(nameof(redirectCallRequest));
            }

            using var message = CreateRedirectCallRequest(redirectCallRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRejectCallRequest(RejectCallRequestInternal rejectCallRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:reject", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(rejectCallRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Reject the call. </summary>
        /// <param name="rejectCallRequest"> The reject call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rejectCallRequest"/> is null. </exception>
        public async Task<Response> RejectCallAsync(RejectCallRequestInternal rejectCallRequest, CancellationToken cancellationToken = default)
        {
            if (rejectCallRequest == null)
            {
                throw new ArgumentNullException(nameof(rejectCallRequest));
            }

            using var message = CreateRejectCallRequest(rejectCallRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reject the call. </summary>
        /// <param name="rejectCallRequest"> The reject call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rejectCallRequest"/> is null. </exception>
        public Response RejectCall(RejectCallRequestInternal rejectCallRequest, CancellationToken cancellationToken = default)
        {
            if (rejectCallRequest == null)
            {
                throw new ArgumentNullException(nameof(rejectCallRequest));
            }

            using var message = CreateRejectCallRequest(rejectCallRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
