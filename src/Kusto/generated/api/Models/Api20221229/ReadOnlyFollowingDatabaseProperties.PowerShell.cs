// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>Class representing the Kusto database properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReadOnlyFollowingDatabasePropertiesTypeConverter))]
    public partial class ReadOnlyFollowingDatabaseProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ReadOnlyFollowingDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabaseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabaseProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReadOnlyFollowingDatabaseProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ReadOnlyFollowingDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabaseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabaseProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReadOnlyFollowingDatabaseProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReadOnlyFollowingDatabaseProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ReadOnlyFollowingDatabaseProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabaseProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ReadOnlyFollowingDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReadOnlyFollowingDatabaseProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Statistics"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).Statistics = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDatabaseStatistics) content.GetValueForProperty("Statistics",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).Statistics, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.DatabaseStatisticsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableLevelSharingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingProperty = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ITableLevelSharingProperties) content.GetValueForProperty("TableLevelSharingProperty",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingProperty, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.TableLevelSharingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SoftDeletePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).SoftDeletePeriod = (global::System.TimeSpan?) content.GetValueForProperty("SoftDeletePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).SoftDeletePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("HotCachePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).HotCachePeriod = (global::System.TimeSpan?) content.GetValueForProperty("HotCachePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).HotCachePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("LeaderClusterResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).LeaderClusterResourceId = (string) content.GetValueForProperty("LeaderClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).LeaderClusterResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AttachedDatabaseConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).AttachedDatabaseConfigurationName = (string) content.GetValueForProperty("AttachedDatabaseConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).AttachedDatabaseConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalsModificationKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).PrincipalsModificationKind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind?) content.GetValueForProperty("PrincipalsModificationKind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).PrincipalsModificationKind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind.CreateFrom);
            }
            if (content.Contains("OriginalDatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).OriginalDatabaseName = (string) content.GetValueForProperty("OriginalDatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).OriginalDatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseShareOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).DatabaseShareOrigin = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin?) content.GetValueForProperty("DatabaseShareOrigin",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).DatabaseShareOrigin, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin.CreateFrom);
            }
            if (content.Contains("StatisticsSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).StatisticsSize = (float?) content.GetValueForProperty("StatisticsSize",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).StatisticsSize, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("TableLevelSharingPropertyTablesToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyTablesToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyTablesToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyTablesToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyExternalTablesToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyExternalTablesToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyExternalTablesToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyExternalTablesToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyMaterializedViewsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyMaterializedViewsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyMaterializedViewsToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyMaterializedViewsToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyFunctionsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyFunctionsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyFunctionsToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyFunctionsToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ReadOnlyFollowingDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReadOnlyFollowingDatabaseProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Statistics"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).Statistics = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDatabaseStatistics) content.GetValueForProperty("Statistics",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).Statistics, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.DatabaseStatisticsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableLevelSharingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingProperty = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ITableLevelSharingProperties) content.GetValueForProperty("TableLevelSharingProperty",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingProperty, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.TableLevelSharingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SoftDeletePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).SoftDeletePeriod = (global::System.TimeSpan?) content.GetValueForProperty("SoftDeletePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).SoftDeletePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("HotCachePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).HotCachePeriod = (global::System.TimeSpan?) content.GetValueForProperty("HotCachePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).HotCachePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("LeaderClusterResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).LeaderClusterResourceId = (string) content.GetValueForProperty("LeaderClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).LeaderClusterResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AttachedDatabaseConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).AttachedDatabaseConfigurationName = (string) content.GetValueForProperty("AttachedDatabaseConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).AttachedDatabaseConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalsModificationKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).PrincipalsModificationKind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind?) content.GetValueForProperty("PrincipalsModificationKind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).PrincipalsModificationKind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalsModificationKind.CreateFrom);
            }
            if (content.Contains("OriginalDatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).OriginalDatabaseName = (string) content.GetValueForProperty("OriginalDatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).OriginalDatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseShareOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).DatabaseShareOrigin = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin?) content.GetValueForProperty("DatabaseShareOrigin",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).DatabaseShareOrigin, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin.CreateFrom);
            }
            if (content.Contains("StatisticsSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).StatisticsSize = (float?) content.GetValueForProperty("StatisticsSize",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).StatisticsSize, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("TableLevelSharingPropertyTablesToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyTablesToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyTablesToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyTablesToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyTablesToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyExternalTablesToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyExternalTablesToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyExternalTablesToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyExternalTablesToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyExternalTablesToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyMaterializedViewsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyMaterializedViewsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyMaterializedViewsToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyMaterializedViewsToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyMaterializedViewsToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyFunctionsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToInclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyFunctionsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToInclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TableLevelSharingPropertyFunctionsToExclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToExclude = (string[]) content.GetValueForProperty("TableLevelSharingPropertyFunctionsToExclude",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IReadOnlyFollowingDatabasePropertiesInternal)this).TableLevelSharingPropertyFunctionsToExclude, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing the Kusto database properties.
    [System.ComponentModel.TypeConverter(typeof(ReadOnlyFollowingDatabasePropertiesTypeConverter))]
    public partial interface IReadOnlyFollowingDatabaseProperties

    {

    }
}