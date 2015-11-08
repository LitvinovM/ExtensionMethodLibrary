namespace VolumeInfo
{
    public sealed partial class VolumeGibibyte : VolumeInfo
    {
        internal VolumeGibibyte(double amount)
            : base(amount)
        {
        }

        internal VolumeGibibyte(VolumeInfo volumeInfo)
            : base(volumeInfo)
        {
        }

        public override long Value
        {
            get { return 1073741824; }
        }

        public override string ToString()
        {
            return string.Format("{0} GiB", this.Amount);
        }
    }
}
