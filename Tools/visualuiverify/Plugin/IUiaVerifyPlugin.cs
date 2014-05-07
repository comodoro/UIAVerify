﻿using System.Collections.Generic;

namespace VisualUIAVerify.Plugin
{
    public interface IUiaVerifyPlugin
    {
        /// <summary>
        /// This method will be called once before using other plugin members
        /// </summary>
        void Initialize();
        
        IEnumerable<IUiaVerifyCustomPatternDescriptor> CustomPatterns { get; }
    }
}