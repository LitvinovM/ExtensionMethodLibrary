namespace VolumeInfo
{
    public sealed partial class VolumeTebibyte : VolumeInfo
    {
        internal VolumeTebibyte(double amount)
            : base(amount)
        {
        }

        internal VolumeTebibyte(VolumeInfo volumeInfo)
            : base(volumeInfo)
        {
        }

        public override long Value
        {
            get { return 1099511627776; }
        }

        public override string ToString()
        {
            return string.Format("{0:#.##} TiB", this.Amount);
        }
    }
}
