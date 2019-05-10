using FitnessTrackerApp.Helpers;
using SQLite;
using System;

namespace FitnessTrackerApp.Models
{
    public class Lift
    {
        public Lift()
        {
        }

        public Lift(
            string name,
            int sets,
            int reps,
            TimeSpan rest)
        {
            ParameterValidator.ValidateStringIsNotNullOrEmpty(name, nameof(name));
            ParameterValidator.ValidateIntInRange(sets, nameof(sets), lowerLimit: 0);
            ParameterValidator.ValidateIntInRange(reps, nameof(reps), lowerLimit: 0);

            this.Name = name;
            this.Sets = sets;
            this.Reps = reps;
            this.Rest = rest;
            this.SuperSet = null;
        }

        public Lift(
            int id,
            int workoutId,
            string name,
            int sets,
            int reps,
            TimeSpan rest)
        {
            ParameterValidator.ValidateIntInRange(id, nameof(id), lowerLimit: 1);
            ParameterValidator.ValidateIntInRange(workoutId, nameof(workoutId), lowerLimit: 1);
            ParameterValidator.ValidateStringIsNotNullOrEmpty(name, nameof(name));
            ParameterValidator.ValidateIntInRange(sets, nameof(sets), lowerLimit: 0);
            ParameterValidator.ValidateIntInRange(reps, nameof(reps), lowerLimit: 0);

            this.Id = id;
            this.WorkoutId = workoutId;
            this.Name = name;
            this.Sets = sets;
            this.Reps = reps;
            this.Rest = rest;
        }

        public Lift(
            string name,
            int sets,
            int reps,
            Lift superSet)
        {
            ParameterValidator.ValidateStringIsNotNullOrEmpty(name, nameof(name));
            ParameterValidator.ValidateIntInRange(sets, nameof(sets), lowerLimit: 0);
            ParameterValidator.ValidateIntInRange(reps, nameof(reps), lowerLimit: 0);
            ParameterValidator.ValidateObjectIsNotNull(superSet, nameof(superSet));

            this.Name = name;
            this.Sets = sets;
            this.Reps = reps;
            this.SuperSet = superSet;
        }

        public Lift(
            int id,
            int workoutId,
            string name,
            int sets,
            int reps,
            Lift superSet)
        {
            ParameterValidator.ValidateIntInRange(id, nameof(id), lowerLimit: 1);
            ParameterValidator.ValidateIntInRange(workoutId, nameof(workoutId), lowerLimit: 1);
            ParameterValidator.ValidateStringIsNotNullOrEmpty(name, nameof(name));
            ParameterValidator.ValidateIntInRange(sets, nameof(sets), lowerLimit: 0);
            ParameterValidator.ValidateIntInRange(reps, nameof(reps), lowerLimit: 0);
            ParameterValidator.ValidateObjectIsNotNull(superSet, nameof(superSet));

            this.Id = id;
            this.WorkoutId = workoutId;
            this.Name = name;
            this.Sets = sets;
            this.Reps = reps;
            this.SuperSet = superSet;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int WorkoutId { get; set; }

        public string Name { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public TimeSpan Rest { get; set; }

        public Lift SuperSet { get; set; }
    }
}
