using System.Collections.Generic;

namespace Pjatk.Pab.OnlineTraveller.Core.Domain.Entities
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }

        protected bool Equals(EntityBase<TId> other)
        {
            return EqualityComparer<TId>.Default.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as EntityBase<TId>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TId>.Default.GetHashCode(Id);
        }

        public static bool operator ==(EntityBase<TId> left, EntityBase<TId> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityBase<TId> left, EntityBase<TId> right)
        {
            return !Equals(left, right);
        }
    }
}