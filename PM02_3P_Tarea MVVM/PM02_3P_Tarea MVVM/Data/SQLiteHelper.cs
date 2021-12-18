using PM02_3P_Tarea_MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PM02_3P_Tarea_MVVM.Data
{
   public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Empleado>().Wait();
        }

        public Task<int> SavePersona(Empleado person)
        {
            if (person.IdEmp != 0)
            {
                return db.UpdateAsync(person);
                ;
            }
            else
            {
                return db.InsertAsync(person);
            }
        }
        /// <summary>
        /// Recuperar todos los personas
        /// </summary>
        /// <returns></returns>
        public Task<List<Empleado>> GetPersonasAync()
        {
            return db.Table<Empleado>().ToListAsync();
        }
        /// <summary>
        /// Recupera las personas por la identidad
        /// </summary>
        /// <param name="identidad">Identidad de la persona requerida</param>
        /// <returns></returns>
        public Task<Empleado> GetPersonaByIdAsync(int person)
        {
            return db.Table<Empleado>().Where(a => a.IdEmp == person).FirstOrDefaultAsync();
        }

        public Task<int> Grabarpersona(Empleado person)
        {
            if (person.IdEmp != 0)
            {
                return db.UpdateAsync(person);
            }
            else
            {
                return db.InsertAsync(person);
            }
        }

        public Task<int> DropPersonaAsync(Empleado person)
        {
            return db.DeleteAsync(person);
        }


    }
}
