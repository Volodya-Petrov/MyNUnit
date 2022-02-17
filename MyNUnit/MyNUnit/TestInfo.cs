using System;

namespace MyNUnit
{   
    /// <summary>
    /// Класс с информацией о результате выполнения теста
    /// </summary>
    public class TestInfo
    {

        public string ClassName { get; set; }
            
        public string Name { get; set; }
        
        public TestState State { get; set; }
        
        public long Time { get; set; }
        
        public string ErrorMessage { get; set; }
        
        public string IgnoreMessage { get; set; }
    }
    
    public enum TestState
    {
        Success,
        Failed,
        Errored,
        Ignored
    }
}