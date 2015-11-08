namespace VolumeInfo
{
    public sealed partial class VolumeMebibyte : VolumeInfo
    {
        internal VolumeMebibyte(double amount)
            : base(amount)
        {
        }

        internal VolumeMebibyte(VolumeInfo volumeInfo)
            : base(volumeInfo)
        {
        }

        public override long Value
        {
            get { return 1048576; }
        }

        public override string ToString()
        {
            return string.Format("{0:#.##} MiB", this.Amount);
        }
    }
}
