﻿using System;

namespace XAMLPatterns.ViewModelLocator.Messages
{
    public class SessionTitleChanged
    {
        public int SessionId { get; set; }
        public string NewTitle { get; set; }
    }
}                                                                          
