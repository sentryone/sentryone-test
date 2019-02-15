﻿// <auto-generated />
namespace LegiTestProject1.SsisFileBasedDeployment_Output
{
    using global::PragmaticWorks.LegiTest.Contracts.Runtime;
    using global::System;
    using global::PragmaticWorks.LegiTest.Runtime;
    using global::NUnit.Framework;
    using global::NUnit.Framework.Interfaces;
    using global::System.Collections.Generic;
    using global::PragmaticWorks.LegiTest.Runtime.Models;
    using global::PragmaticWorks.Common.Wrappers;
    using global::System.Xml.Linq;
    using global::PragmaticWorks.LegiTest.Ssis2016.Runtime;
    using global::PragmaticWorks.LegiTest.Runtime.Exceptions;
    using global::PragmaticWorks.LegiTest.Ssis.Runtime;
    using global::PragmaticWorks.Common.Sql.Filtering;
    using global::PragmaticWorks.LegiTest.Runtime.Helper;
    using global::PragmaticWorks.Common.Sql.ValueComparison;
    using global::System.Globalization;
    using global::System.CodeDom.Compiler;
    
    
    // This class was auto-generated by LegiTest
    // Modifications to this class will be over-written if the test suite is regenerated.
    [TestFixture]
    [GeneratedCode("PragmaticWorks.LegiTest", "2019.1.2.0")]
    [UniqueId("303e2924-4bbd-4640-86da-bd24967aad36")]
    public partial class SsisFileBasedDeployment
    {
        
        // Test resources used for passing resources between steps
        private IResourceProvider _testResources;
        
        // Test state tracker used to co-ordinate pushing results to SentryOne Test
        static ITestStateTracker testStateTracker;
        
        // Parameter provider used to find parameters for individual elements
        static IParameterProvider parameterProvider;
        
        static partial void BeforeTest(string testName, Dictionary<string, object> testResources, ref bool cancel);
        static partial void AfterTest(string testName, Dictionary<string, object> testResources);
        static partial void BeforeTestElement(string testName, string elementName, Dictionary<string, object> testResources, ref bool cancel);
        static partial void AfterTestElement(string testName, string elementName, Dictionary<string, object> testResources);
        
        static SsisFileBasedDeployment()
        {
            // Create the parameter provider used to find parameters for individual elements.
            parameterProvider = new ParameterProvider(new Guid("16db26af-28f6-4959-ace5-786b48a985d4"), typeof(SsisFileBasedDeployment));
        }
        
        [OneTimeSetUp]
        public static void GroupSetup()
        {
            // Print debug information to the console to aid with parameter debugging.
            ParameterProvider.PrintDebugInformation(parameterProvider);
            // Create the test state tracker to track the group's run state against SentryOne Test.
            testStateTracker = new TestStateTracker(typeof(SsisFileBasedDeployment), Resources.TestManifest_SsisFileBasedDeployment_303e29244bbd464086dabd24967aad36, TestAssemblyInformation.AssemblyTestCount, TestAssemblyInformation.SuiteTestCounts, parameterProvider);
            // Inform the server that the test group has started.
            testStateTracker.RegisterGroupStarted();
        }
        
        [SetUp]
        public void Setup()
        {
            // Create the test resources
            _testResources = new ResourceProvider();
            // Make the test resources available to the parameter provider
            parameterProvider.SetResourcesSource(_testResources);
            // Inform the server that the test has started.
            testStateTracker.RegisterTestStarted(TestContext.CurrentContext.Test.Name);
        }
        
        [TearDown]
        public void Teardown()
        {
            // Inform the server that the test has ended.
            testStateTracker.RegisterTestEnded(TestContext.CurrentContext.Test.Name, (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed), (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed), (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Inconclusive), (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Skipped));
        }
        
        [OneTimeTearDown]
        public static void GroupTeardown()
        {
            // Inform the server that the test group has ended.
            testStateTracker.RegisterGroupEnded();
        }
        
        // Implementation for test RunPackage
        [Category("SsisFileBasedDeployment")]
        [Test]
        [UniqueId("452f8682-7529-406f-a676-7a6718a48050")]
        public void RunPackage()
        {
            Dictionary<string, object> beforeTestResourceSnapshot = _testResources.Snapshot();
            bool cancel = false;
            BeforeTest("RunPackage", beforeTestResourceSnapshot, ref cancel);
            if (cancel)
            {
                return;
            }
            _testResources.Merge(beforeTestResourceSnapshot);

            try
            {
                // Call implementation for step Load Package
                testStateTracker.RunElement(new Guid("83b00f0e-80ad-46d6-bfa0-6102d12c3b44"), "Load Package", TestStepType.TestSetup, RunPackage_LoadPackage);
                // Call implementation for step Execute Package from File System
                testStateTracker.RunElement(new Guid("e66342c6-c062-4f5c-a6f9-7f9eb58c0dc8"), "Execute Package from File System", TestStepType.Test, RunPackage_ExecutePackagefromFileSystem);
                // Call implementation for step Check for Success
                testStateTracker.RunAssert(new Guid("61b8f948-1b79-4609-ab4b-021e566201d7"), "Check for Success", RunPackage_CheckforSuccess);
            }
            finally
            {
                Dictionary<string, object> afterTestResourceSnapshot = _testResources.Snapshot();
                AfterTest("RunPackage", afterTestResourceSnapshot);
                _testResources.Merge(afterTestResourceSnapshot);
            }
        }
        
        // Implementation for step Load Package for RunPackage
        private void RunPackage_LoadPackage()
        {
            Dictionary<string, object> beforeTestElementResourceSnapshot = _testResources.Snapshot();
            bool cancel = false;
            BeforeTestElement("RunPackage", "Load Package", beforeTestElementResourceSnapshot, ref cancel);
            if (cancel)
            {
                return;
            }
            _testResources.Merge(beforeTestElementResourceSnapshot);

            try
            {
                try
                {
                    // Read asset EmptyPackage
                    FileSystemObject packageReference = FileSystemObject.ConvertFromXElement(XElement.Parse(Resources.TestResource_EmptyPackage_56af6c9fada049d889aab741b9c7b300));
                    packageReference.ConnectionString = parameterProvider.GetTypedParameter<string>(new Guid("56af6c9f-ada0-49d8-89aa-b741b9c7b300"), "ConnectionString", packageReference.ConnectionString);
                    packageReference.FullPath = parameterProvider.GetTypedParameter<string>(new Guid("56af6c9f-ada0-49d8-89aa-b741b9c7b300"), "FullPath", packageReference.FullPath);
                    packageReference.OriginalSource = parameterProvider.GetTypedParameter<string>(new Guid("56af6c9f-ada0-49d8-89aa-b741b9c7b300"), "OriginalItemPath", packageReference.OriginalSource);
                    _testResources["EmptyPkgRef"] = new SsisActionProvider().Load(packageReference);
                }
                catch (Exception exception)
                {
                    throw new TestInitializationStepException("SsisFileBasedDeployment", "RunPackage", "Load Package", exception);
                }
            }
            finally
            {
                Dictionary<string, object> afterTestElementResourceSnapshot = _testResources.Snapshot();
                AfterTestElement("RunPackage", "Load Package", afterTestElementResourceSnapshot);
                _testResources.Merge(afterTestElementResourceSnapshot);
            }
        }
        
        // Implementation for step Execute Package from File System for RunPackage
        private void RunPackage_ExecutePackagefromFileSystem()
        {
            Dictionary<string, object> beforeTestElementResourceSnapshot = _testResources.Snapshot();
            bool cancel = false;
            BeforeTestElement("RunPackage", "Execute Package from File System", beforeTestElementResourceSnapshot, ref cancel);
            if (cancel)
            {
                return;
            }
            _testResources.Merge(beforeTestElementResourceSnapshot);

            try
            {
                try
                {
                    PackageHolder package = ((PackageHolder)(_testResources["EmptyPkgRef"]));
                    ISsisActionProvider actionProvider = package.ActionProvider;
                    string messages;
                    bool executionResult = actionProvider.Execute(package, out messages);
                    try
                    {
                        Assert.IsTrue(executionResult, ("Package execution failed: " + messages));
                        testStateTracker.PushAssertResult(new Guid("e66342c6-c062-4f5c-a6f9-7f9eb58c0dc8"), "Execute Package from File System : Package Execution Result", true, executionResult, true);
                    }
                    catch
                    {
                        testStateTracker.PushAssertResult(new Guid("e66342c6-c062-4f5c-a6f9-7f9eb58c0dc8"), "Execute Package from File System : Package Execution Result", true, executionResult, false);
                        throw;
                    }
                    _testResources["EmptyPkgResult"] = executionResult;
                }
                catch (Exception exception)
                {
                    throw new TestExecutionStepException("SsisFileBasedDeployment", "RunPackage", "Execute Package from File System", 1, exception);
                }
            }
            finally
            {
                Dictionary<string, object> afterTestElementResourceSnapshot = _testResources.Snapshot();
                AfterTestElement("RunPackage", "Execute Package from File System", afterTestElementResourceSnapshot);
                _testResources.Merge(afterTestElementResourceSnapshot);
            }
        }
        
        // Implementation for step Check for Success for RunPackage
        private void RunPackage_CheckforSuccess()
        {
            Dictionary<string, object> beforeTestElementResourceSnapshot = _testResources.Snapshot();
            bool cancel = false;
            BeforeTestElement("RunPackage", "Check for Success", beforeTestElementResourceSnapshot, ref cancel);
            if (cancel)
            {
                return;
            }
            _testResources.Merge(beforeTestElementResourceSnapshot);

            try
            {
                try
                {
                    object actual = FilterFactory.Coerce(_testResources["EmptyPkgResult"], typeof(bool));
                    object expected = FilterFactory.Coerce(parameterProvider.GetTypedParameter<string>(new Guid("61b8f948-1b79-4609-ab4b-021e566201d7"), "ExpectedValue", "true"), typeof(bool));
                    string actualString;
                    if ((actual == null))
                    {
                        actualString = "null";
                    }
                    else
                    {
                        actualString = actual.ToString();
                    }
                    try
                    {
                        Assert.IsTrue(ValueComparer.Compare(expected, actual, ValueComparisonType.ExactValue, ""), (parameterProvider.ExpandParametersAndEnvironmentVariables(string.Format(CultureInfo.CurrentCulture, "Test resource \'{0}\' was expected to {1} \'{2}\'{3}, actual value was ", "EmptyPkgResult", "be exactly equal to", expected, "")) + actualString));
                        testStateTracker.PushAssertResult(new Guid("61b8f948-1b79-4609-ab4b-021e566201d7"), "Check for Success : Value comparison", expected, actual, true);
                    }
                    catch
                    {
                        testStateTracker.PushAssertResult(new Guid("61b8f948-1b79-4609-ab4b-021e566201d7"), "Check for Success : Value comparison", expected, actual, false);
                        throw;
                    }
                }
                catch (AssertionException exception)
                {
                    throw new AssertionException(string.Format(CultureInfo.CurrentCulture, "\n\nGroup: {0}\nTest: {1}\nAssertion: {2}\n\n{3}", "SsisFileBasedDeployment", "RunPackage", "Check for Success", exception.Message), exception.InnerException);
                }
                catch (Exception exception)
                {
                    throw new TestAssertionException("SsisFileBasedDeployment", "RunPackage", "Check for Success", exception);
                }
            }
            finally
            {
                Dictionary<string, object> afterTestElementResourceSnapshot = _testResources.Snapshot();
                AfterTestElement("RunPackage", "Check for Success", afterTestElementResourceSnapshot);
                _testResources.Merge(afterTestElementResourceSnapshot);
            }
        }
    }
}
