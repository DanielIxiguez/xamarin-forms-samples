using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace MobileCRM.Shared.Models
{

    public class Author2
    {
        public string Term { get; set; }
        public object Scheme { get; set; }
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public object Href { get; set; }
        public string Type { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Deleted { get; set; }
        public object Author { get; set; }
        public object License { get; set; }
        public object Lang { get; set; }
        public object Base { get; set; }
        public string Myid { get; set; }
        public object Parentid { get; set; }
        public bool Changed { get; set; }
    }
    
}
