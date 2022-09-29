using Commerce.Data.Engine.Core.Database;
using Commerce.Data.Engine.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Core.Context
{
    public class EntityContext<T> : IEntityContext<T> where T : class, IBaseEntity
    {
        private readonly DatabaseContext _db;
        private DbSet<T> _DbSet;
        public EntityContext(DatabaseContext db)
        {
            this._db = db;
            _DbSet = db.Set<T>();
        }

        public async virtual Task<int> Delete(T Entity)
        {
            _DbSet.Remove(Entity);
            return await _db.SaveChangesAsync();
        }

        public virtual async Task<int> Insert(T Entity)
        {
            if (Entity.Id == Guid.Empty) Entity.Id = Guid.NewGuid();
            Entity.CreatedDate = DateTime.UtcNow;
            var msgs = await this.Validate(ActionTypes.Insert, Entity);
            if (msgs?.Length > 0) throw new Exception("401", new Exception(String.Join("U+002CU+0020", msgs)));
            else
            {
                var entry = this._DbSet.Add(Entity);
                entry.State = EntityState.Added;
                var res = await _db.SaveChangesAsync();
                entry.State = EntityState.Detached;
                return res;
            }
        }

        public virtual async Task<int> InsertMultiple(IEnumerable<T> Entities)
        {
            if (Entities.Count() == 0) return 0;
            var entries = new List<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T>>();
            foreach (var entity in Entities)
            {
                if (entity.Id == Guid.Empty) entity.Id = Guid.NewGuid();
                entity.CreatedDate = DateTime.UtcNow;

                var msgs = await this.Validate(ActionTypes.Insert, entity);
                if (msgs.Length > 0) throw new Exception();
                else
                {
                    var entry = this._DbSet.Add(entity);
                    entry.State = EntityState.Added;
                    entries.Add(entry);
                }
            }
            var res = await _db.SaveChangesAsync();
            foreach (var e in entries) e.State = EntityState.Detached;
            return res;
        }

        public virtual async Task<IEnumerable<T>> Read(Expression<Func<T, bool>> e)
            => await this._DbSet.Where(e).ToListAsync();

        public virtual async Task<IEnumerable<T>> ReadAll()
            => await _DbSet.ToListAsync();

        public virtual async Task<int> Update(T Entity)
        {
            var entry = await this._DbSet.FirstOrDefaultAsync(d => d.Id == Entity.Id);
            if (entry == null) throw new NullReferenceException();

            var msgs = await this.Validate(ActionTypes.Update, Entity);
            if (msgs.Length > 0) throw new Exception();
            else
            {
                this._DbSet.Attach(entry);
                entry = Entity;
                _db.Entry(Entity).State = EntityState.Modified;
                var res = await _db.SaveChangesAsync();
                _db.Entry(Entity).State = EntityState.Detached;
                return res;
            }
        }

        public virtual async Task<string[]> Validate(ActionTypes type, T Entity)
        {
            var list = new List<string>();
            if ((await this._DbSet.Where(d => d.Id == Entity.Id).ToListAsync()).Count > 0) list.Add("err");
            return list.ToArray();
        }
    }
}
