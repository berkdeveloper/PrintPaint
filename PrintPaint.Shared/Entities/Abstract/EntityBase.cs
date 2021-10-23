using Newtonsoft.Json;
using System;

namespace PrintPaint.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        [JsonIgnore]
        public virtual int Id { get; set; }
        [JsonIgnore]
        public virtual DateTime CreatDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public virtual bool IsDeleted { get; set; } = false;
        [JsonIgnore]
        public virtual bool IsActive { get; set; } = true;
        [JsonIgnore]
        public virtual string CreatedByName { get; set; } = "Admin"; //Yorum oluşturma 
        [JsonIgnore]
        public virtual string ModifiedByName { get; set; } = "Admin"; // Yorum düzenleme
    }
}
