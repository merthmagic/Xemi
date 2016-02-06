using System.Collections.Generic;

namespace Xemi.Domain.Entities
{
    public abstract class BaseEntityOfTKey<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is BaseEntityOfTKey<TKey>))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            var other = (BaseEntityOfTKey<TKey>)obj;
            if (IsTransient() && other.IsTransient())
            {
                return false;
            }

            //Must have a IS-A relation of types or must be same type
            var typeOfThis = GetType();
            var typeOfOther = other.GetType();
            if (!typeOfThis.IsAssignableFrom(typeOfOther) && !typeOfOther.IsAssignableFrom(typeOfThis))
            {
                return false;
            }

            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public virtual bool IsTransient()
        {
            return EqualityComparer<TKey>.Default.Equals(Id, default(TKey));
        }

        public static bool operator ==(BaseEntityOfTKey<TKey> left, BaseEntityOfTKey<TKey> right)
        {
            if (Equals(left, null))
            {
                return Equals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(BaseEntityOfTKey<TKey> left, BaseEntityOfTKey<TKey> right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return string.Format("[{0} {1}]", GetType().Name, Id);
        }
    }
}