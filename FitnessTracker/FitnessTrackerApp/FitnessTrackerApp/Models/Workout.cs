using FitnessTrackerApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrackerApp.Models
{
    public class Workout
    {
        public Workout()
        {
        }

        public Workout(
            string name,
            DateTime createDate,
            List<Lift> lifts)
        {
            ParameterValidator.ValidateStringIsNotNullOrEmpty(name, nameof(name));
            ParameterValidator.ValidateCollectionIsNotNullOrEmpty(lifts, nameof(lifts));

            this.CreateDate = createDate;
            this.CreateDate = createDate;
            this.Lifts = lifts;
        }

        public Workout(
            int id,
            string name,
            DateTime createDate,
            List<Lift> lifts)
        {
            ParameterValidator.ValidateIntInRange(id, nameof(id), lowerLimit: 1);
            ParameterValidator.ValidateStringIsNotNullOrEmpty(name, nameof(name));
            ParameterValidator.ValidateCollectionIsNotNullOrEmpty(lifts, nameof(lifts));

            this.Id = id;
            this.Name = name;
            this.CreateDate = createDate;
            this.Lifts = lifts;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public List<Lift> Lifts { get; set; }
    }
}
