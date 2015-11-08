namespace VolumeInfo
{
    public sealed partial class VolumePebibyte : VolumeInfo
    {
        internal VolumePebibyte(double amount)
            : base(amount)
        {
        }

        internal VolumePebibyte(VolumeInfo volumeInfo)
            : base(volumeInfo)
        {
        }

        public override long Value
        {
            get { return 1125899906842624; }
        }

        public override string ToString()
        {
            return string.Format("{0:#.##} PiB", this.Amount);
        }
    }
}
