using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMethodShareDtNt
{
    public class FoodAll: Food_Log
    {
        

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Meal")]
        public string Meal { get; set; }

        [BsonElement("Calorie_Count")]
        public int CalorieCount { get; set; }

        [BsonElement("Consumption_Date")]
        public DateTime ConsumptionDate { get; set; }

        [BsonElement("Meal_Description")]
        public string MealDescription { get; set; }



    }

}
