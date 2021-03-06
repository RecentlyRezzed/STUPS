﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/21/2014
 * Time: 12:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Interfaces
{
    using Remoting;

    // using System.Management.Automation;
    
    /// <summary>
    /// Description of AddTestCaseCmdletBaseDataObject.
    /// </summary>
    public class AddTestCaseCmdletBaseDataObject : IAddTestCaseCmdletBaseDataObject
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string TestPlatformId { get; set; }
        // 20141211
        // public ScriptBlock[] TestCode { get; set; }
        public ICodeBlock[] TestCode { get; set; }
    }
}
