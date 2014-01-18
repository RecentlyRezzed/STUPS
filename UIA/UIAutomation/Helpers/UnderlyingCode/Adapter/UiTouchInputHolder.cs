﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/18/2014
 * Time: 1:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    /// <summary>
    /// Description of UiTouchInputHolder.
    /// </summary>
    public class UiTouchInputHolder : ITouchInputHolder
    {
        private IUiElement _parentElement;
        
        public UiTouchInputHolder()
        {
        }
        
        public void SetParentElement(IUiElement parentElement)
        {
            _parentElement = parentElement;
        }
        
        public IUiElement GetParentElement()
        {
            return _parentElement;
        }
    }
}