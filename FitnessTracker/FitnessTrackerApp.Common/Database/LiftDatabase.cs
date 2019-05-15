using FitnessTrackerApp.Helpers;
using FitnessTrackerApp.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessTrackerApp.Database
{
    public class LiftDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public LiftDatabase(string databasePath)
        {
            ParameterValidator.ValidateStringIsNotNullOrEmpty(databasePath, nameof(databasePath));

            this.database = new SQLiteAsyncConnection(databasePath);
            this.database.CreateTableAsync<Lift>().Wait();
        }

        public Task<List<Lift>> GetLiftsAsync()
        {
            return this.database.Table<Lift>().ToListAsync();
        }

        public Task<Lift> GetLiftAsync(int liftId)
        {
            return this.database.Table<Lift>().Where(lift => lift.Id == liftId).FirstOrDefaultAsync();
        }

        public Task<int> SaveLiftAsync(Lift lift)
        {
            if (lift.Id == 0)
            {
                return this.database.InsertAsync(lift);
            }
            else
            {
                return this.database.UpdateAsync(lift);
            }
        }

        public Task<int> DeleteLiftAsync(Lift lift)
        {
            return this.database.DeleteAsync(lift);
        }
    }
}
