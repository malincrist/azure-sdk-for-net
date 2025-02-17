// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_OfferResource
    {
        // Get Offer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetOffer()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2022-12-01/examples/GetOffer.json
            // this example is just showing the usage of "Offers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OfferResource created on azure
            // for more information of creating OfferResource, please refer to the document of OfferResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string publisherName = "publisher1";
            string offerName = "offer1";
            ResourceIdentifier offerResourceId = OfferResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, publisherName, offerName);
            OfferResource offer = client.GetOfferResource(offerResourceId);

            // invoke the operation
            OfferResource result = await offer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OfferData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
