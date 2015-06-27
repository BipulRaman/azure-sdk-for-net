//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Net;
using Microsoft.Azure;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Test;
using Xunit;
using Microsoft.Azure.Test.HttpRecorder;

namespace ResourceGroups.Tests
{
    public class LiveTagsTests : TestBase
    {
        const string DefaultLocation = "South Central US";

        public ResourceManagementClient GetResourceManagementClient(RecordedDelegatingHandler handler)
        {
            handler.IsPassThrough = true;
            var client = this.GetResourceManagementClientWithHandler(handler);
            if (HttpMockServer.Mode == HttpRecorderMode.Playback)
            {
                client.LongRunningOperationRetryTimeout = 0;
            }

            return client;
        }

        [Fact]
        public void CreateListAndDeleteSubscriptionTag()
        {
            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();

                string tagName = TestUtilities.GenerateName("csmtg");

                var client = GetResourceManagementClient(handler);
                var createResult = client.Tags.CreateOrUpdate(tagName);

                Assert.Equal(tagName, createResult.TagName);
                
                var listResult = client.Tags.List();
                Assert.True(listResult.Value.Count > 0);

                client.Tags.Delete(tagName);
            }
        }

        [Fact]
        public void CreateListAndDeleteSubscriptionTagValue()
        {
            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            using (UndoContext context = UndoContext.Current)
            {
                context.Start();

                string tagName = TestUtilities.GenerateName("csmtg");
                string tagValue = TestUtilities.GenerateName("csmtgv");

                var client = GetResourceManagementClient(handler);
                var createNameResult = client.Tags.CreateOrUpdate(tagName);
                var createValueResult = client.Tags.CreateOrUpdateValue(tagName, tagValue);

                Assert.Equal(tagName, createNameResult.TagName);
                Assert.Equal(tagValue, createValueResult.TagValueProperty);

                var listResult = client.Tags.List();
                Assert.True(listResult.Value.Count > 0);

                client.Tags.DeleteValue(tagName, tagValue);
                client.Tags.Delete(tagName);
            }
        }

        [Fact]
        public void CreateTagValueWithoutCreatingTag()
        {
            var handler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            using (UndoContext context = UndoContext.Current)
            {
                context.Start();

                string tagName = TestUtilities.GenerateName("csmtg");
                string tagValue = TestUtilities.GenerateName("csmtgv");

                var client = GetResourceManagementClient(handler);
                Assert.Throws<CloudException>(() => client.Tags.CreateOrUpdateValue(tagName, tagValue));
            }
        }
    }
}