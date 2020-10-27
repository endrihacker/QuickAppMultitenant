using Finbuckle.MultiTenant;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ExtendedTenantInfo : ITenantInfo
    {
        public string Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }

        public bool? TestBool { get; set; }
        public string TestString { get; set; }
        public DateTime TestDateTime { get; set; }
    }
}
