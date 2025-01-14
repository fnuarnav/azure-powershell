﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.RedisCache
{
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.RedisCache.Properties;
    using ResourceManager.Common.ArgumentCompleters;

    [Cmdlet("Import", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RedisCache", SupportsShouldProcess = true), OutputType(typeof(bool))]
    public class ImportAzureRedisCache : RedisCacheCmdletBase
    {
        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = false, HelpMessage = "Name of resource group under which cache exists.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true, HelpMessage = "Name of redis cache.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true, HelpMessage = "SAS url for blobs that needed to be imported.")]
        [ValidateNotNullOrEmpty]
        public string[] Files { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = false, HelpMessage = "Format for import operation.")]
        public string Format { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = false, HelpMessage = "Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS.")]
        [PSArgumentCompleter("SAS", "ManagedIdentity")]
        public string PreferredDataArchiveAuthMethod { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            Utility.ValidateResourceGroupAndResourceName(ResourceGroupName, Name);
            ResourceGroupName = CacheClient.GetResourceGroupNameIfNotProvided(ResourceGroupName, Name);

            ConfirmAction(
                Force.IsPresent,
                string.Format(Resources.ImportingRedisCache, Name),
                string.Format(Resources.ImportRedisCache, Name),
                Name,
                () => CacheClient.ImportToCache(ResourceGroupName, Name, Files, Format,PreferredDataArchiveAuthMethod));

            if (PassThru)
            {
                WriteObject(true);
            }
        }
    }
}
