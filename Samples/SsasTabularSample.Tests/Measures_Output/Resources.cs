﻿// <auto-generated />
namespace SsasTabularSample.Tests.Measures_Output
{
    using global::System;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Resources;
    using global::System.Globalization;
    using global::System.ComponentModel;
    using global::System.CodeDom.Compiler;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager temp = new ResourceManager("SsasTabularSample.Tests.Measures_Output.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;&lt;TestManifest failOnServerPublishFailureExpression=&quot;False&quot; testSuiteId=&quot;163617d2-c58d-47a6-8835-2ae96adde9f2&quot; testSuiteName=&quot;Measures&quot; testGroupId=&quot;ba4d7b12-1e28-46b0-98de-25985bf04323&quot; testGroupName=&quot;Measures&quot; isSingleGroupMode=&quot;True&quot;&gt;&lt;Keys&gt;&lt;Key key=&quot;TestSuiteRevision&quot; value=&quot;5&quot; /&gt;&lt;/Keys&gt;&lt;MethodAssociations&gt;&lt;MethodAssociation methodName=&quot;CheckSalesAmount&quot; testName=&quot;Check Sales Amount&quot; testUniqueId=&quot;759cfc01-706a-4f1e-828f-33d4de788d41&quot; /&gt;&lt;/MethodAssociations&gt;&lt;/TestMan [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestManifest_Measures_ba4d7b121e2846b098de25985bf04323
        {
            get
            {
                return ResourceManager.GetString("TestManifest_Measures_ba4d7b121e2846b098de25985bf04323", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_AdventureWorksInternetSales_aa032db7d7bb44bd9d63c5c7effa1bef
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_AdventureWorksInternetSales_aa032db7d7bb44bd9d63c5c7effa1bef", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to evaluate
        ///(
        ///  summarize
        ///   (
        ///     &apos;Internet Sales&apos;,
        ///     &quot;Total Sales Amount&quot;, sum(&apos;Internet Sales&apos;[Sales Amount])
        ///   )
        ///).
        /// </summary>
        internal static string TestResource_TotalSalesAmount_6062708b57784252aa032266a220656e
        {
            get
            {
                return ResourceManager.GetString("TestResource_TotalSalesAmount_6062708b57784252aa032266a220656e", resourceCulture);
            }
        }
    }
}

