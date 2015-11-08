using System;
using System.Diagnostics;

namespace VolumeInfo
{
    public abstract class VolumeInfo : IComparable<VolumeInfo>
    {
        protected VolumeInfo(double amount)
        {
            this.Amount = amount;
            this._amountByte = amount * this.Value;
        }

        protected VolumeInfo(VolumeInfo volumeInfo)
        {
            this.Amount = volumeInfo._amountByte / this.Value;
            this._amountByte = volumeInfo._amountByte;
        }

        /// <summary>
        ///  Unit amount of information equal to <see cref="Value"/> byte
        /// </summary>
        public abstract long Value { get; }

        /// <summary>
        /// the amount of information in the current measurement unit
        /// </summary>
        public double Amount { get; private set; }

        /// <summary>
        /// the amount of information in the byte
        /// </summary>
        public double AmountByte { get { return this._amountByte; } }

        #region operation

        public static bool operator ==(VolumeInfo firstValue, VolumeInfo secondValue)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(firstValue, secondValue))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)firstValue == null) || ((object)secondValue == null))
            {
                return false;
            }

            // Return true if the fields match:
            return Math.Abs(firstValue.AmountByte - secondValue.AmountByte) < Tolerance;
        }

        public static bool operator !=(VolumeInfo firstValue, VolumeInfo secondValue)
        {
            return !(firstValue == secondValue);
        }

        #endregion

        public int CompareTo(VolumeInfo other)
        {
            if (other == null)
                return 1;

            if (Math.Abs(this.AmountByte - other.AmountByte) < Tolerance)
            {
                return 0;
            }

            if (this.AmountByte > other.AmountByte)
            {
                return 1;
            }

            return -1;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((VolumeInfo)obj);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        protected bool Equals(VolumeInfo other)
        {
            return Math.Abs(Amount - other.Amount) < Tolerance;
        }

        private const double Tolerance = 0.00001;

        private readonly double _amountByte;
    }
}
