using Commerce.Data.Engine.Enum;
using System.Linq.Expressions;

namespace Commerce.Data.Engine.Core.Context
{
    public interface IEntityContext<T> where T : IBaseEntity
    {
        public Task<IEnumerable<T>> ReadAll();
        public Task<IEnumerable<T>> Read(Expression<Func<T, bool>> e);
        public Task<int> Update(T Entity);
        public Task<int> Insert(T Entity);
        public Task<int> Delete(T Entity);
        public Task<string[]> Validate(ActionTypes type, T Entity);
    }
}
