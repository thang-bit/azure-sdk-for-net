﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Management.HDInsight.Tests.UnitTests
{
    using Microsoft.Azure.Management.HDInsight;
    using Microsoft.Azure.Management.HDInsight.Models;
    using Microsoft.Rest;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    public class CustomizationTests
    {
        private string ResourceGroupName = "rg1";
        private string ClusterName = "cluster";

        [Fact]
        public void TestCreateCustomization()
        {
            string testName = "TestCreateCustomization";
            TestDelegatingHandler handler = new TestDelegatingHandler();
            HDInsightManagementClient client = GetHDInsightUnitTestingClient(handler);

            client.Clusters.BeginCreating(ResourceGroupName, ClusterName, ClusterCreateParametersHelpers.GetCustomCreateParametersIaas(testName));
            client.Clusters.BeginCreate(ResourceGroupName, ClusterName, ClusterCreateParametersHelpers.GetIaasClusterSpec(testName.ToLowerInvariant()));
            
            Assert.Equal(handler.Requests[0], handler.Requests[1]);
        }

        [Fact]
        public void TestResizeCustomization()
        {
            TestDelegatingHandler handler = new TestDelegatingHandler();
            HDInsightManagementClient client = GetHDInsightUnitTestingClient(handler);

            int newSize = 5;
            client.Clusters.BeginResizing(ResourceGroupName, ClusterName, newSize);
            client.Clusters.BeginResize(ResourceGroupName, ClusterName, new ClusterResizeParameters
            {
                TargetInstanceCount = newSize
            });

            Assert.Equal(handler.Requests[0], handler.Requests[1]);
        }

        [Fact]
        public void TestEnableHttpCustomization()
        {
            TestDelegatingHandler handler = new TestDelegatingHandler();
            HDInsightManagementClient client = GetHDInsightUnitTestingClient(handler);

            string username = "admin";
            string password = "NewPassword123";
            client.Configurations.BeginEnablingHttp(ResourceGroupName, ClusterName, username, password);
            client.Configurations.BeginUpdateHTTPSettings(ResourceGroupName, ClusterName, ConfigurationKey.Gateway,
                ConfigurationsConverter.Convert(new HttpConnectivitySettings
                {
                    EnabledCredential = "true",
                    Password = password,
                    Username = username
                }));

            Assert.Equal(handler.Requests[0], handler.Requests[1]);
        }

        public void TestDisableHttpCustomization()
        {
            TestDelegatingHandler handler = new TestDelegatingHandler();
            HDInsightManagementClient client = GetHDInsightUnitTestingClient(handler);

            client.Configurations.BeginDisablingHttp(ResourceGroupName, ClusterName);
            client.Configurations.BeginUpdateHTTPSettings(ResourceGroupName, ClusterName, ConfigurationKey.Gateway,
                ConfigurationsConverter.Convert(new HttpConnectivitySettings
                {
                    EnabledCredential = "false"
                }));

            Assert.Equal(handler.Requests[0], handler.Requests[1]);
        }

        [Fact]
        public void TestExecuteScriptActionsCustomizations()
        {
            TestDelegatingHandler handler = new TestDelegatingHandler();
            HDInsightManagementClient client = GetHDInsightUnitTestingClient(handler);

            List<RuntimeScriptAction> scriptActions = new List<RuntimeScriptAction>
            {
                new RuntimeScriptAction
                {
                    Name = "name",
                    Parameters = "params",
                    Roles = new List<string>{"headnode", "workernode"},
                    Uri = "http://foo.bar"
                }
            };
            client.Clusters.BeginExecuteScriptActions(ResourceGroupName, ClusterName, new ExecuteScriptActionParameters
            {
                PersistOnSuccess = true,
                ScriptActions = scriptActions
            });
            client.Clusters.BeginExecuteScriptActions(ResourceGroupName, ClusterName, scriptActions, true);

            Assert.Equal(handler.Requests[0], handler.Requests[1]);
        }

        private HDInsightManagementClient GetHDInsightUnitTestingClient(TestDelegatingHandler handler)
        {
            ServiceClientCredentials cred = new BasicAuthenticationCredentials();
            HDInsightManagementClient client = new HDInsightManagementClient(cred, handler)
            {
                SubscriptionId = Guid.NewGuid().ToString()
            };

            return client;
        }

        private class TestDelegatingHandler : DelegatingHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                string content = await request.Content.ReadAsStringAsync();
                Requests.Add(content);

                return new HttpResponseMessage
                {
                    Content = new StringContent(string.Empty)
                };
            }

            public List<string> Requests { get; private set; }

            public TestDelegatingHandler()
            {
                Requests = new List<string>();
            }
        }
    }
}
