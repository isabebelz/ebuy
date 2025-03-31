﻿namespace ebuy.Domain.SeedWork
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public override int GetHashCode() => (GetType().GetHashCode()) + Id.GetHashCode();

        public override string ToString() => $"{GetType().Name} [Id={Id}]";

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Entity)
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (GetType() != obj.GetType())
                return false;

            return base.Equals(obj);
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return Object.Equals(right, null);
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }
    }
}
