using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMethodShareDtNt
{
    public class ExerciseAll: Exercise_Log
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Exercise_ID")]
        public int ExerciseId { get; set; }

        [BsonElement("Calorie_Count")]
        public int CalorieCount { get; set; }

        [BsonElement("Exercise_Date")]
        public DateTime ExerciseDate { get; set; }

        [BsonElement("Exercise_Time")]
        public int ExerciseTime { get; set; }
    }
}
