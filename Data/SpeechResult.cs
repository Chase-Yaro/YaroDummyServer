using System;

namespace UnrealServer.Data
{
    public class SpeechResult {
        public int Id { get; set; }
        public string ResultText { get; set; }
        public DateTime TimeStamp { get; set; }
    }   
}