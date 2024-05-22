﻿namespace PasswordGenerator
{
    public class GenerateConfig
    {
        public int Length { get; set; }
        public bool IsLowerCase {  get; set; }
        public bool IsUpperCase { get; set; }
        public bool IsDigits {  get; set; }
        public bool IsSymbols { get; set; }
    }
}
