﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/5/2012
 * Time: 5:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXUnitTests.CheckCmdletParameters
{
    using MbUnit.Framework;
   
    /// <summary>
    /// Description of StopSeInternetExplorer32CommandTestFixture.
    /// </summary>
    public class StopSeInternetExplorer32Command_ParamCheck
    {
        public StopSeInternetExplorer32Command_ParamCheck()
        {
        }
        
        [SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspaceForParamChecks();
        }
        
        [TearDown]
        public void DisposeRunspace()
        {
            // MiddleLevelCode.DisposeRunspace(); // 20121226
        }
        
        [Test]
        [Category("Fast")]
        public void StopSeInternetExplorer32_InputObject_NoInstanceName()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Stop-SeInternetExplorer -InputObject $null;");
        }
        
        [Test]
        [Category("Fast")]
        public void StopSeInternetExplorer32_InstanceName()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Stop-SeInternetExplorer -InstanceName aaa;");
        }
    }
}
