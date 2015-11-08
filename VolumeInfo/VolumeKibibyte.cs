namespace VolumeInfo
{
    public sealed partial class VolumeKibibyte : VolumeInfo
    {
        internal VolumeKibibyte(double amount)
            : base(amount)
        {
        }

        internal VolumeKibibyte(VolumeInfo volumeInfo)
            : base(volumeInfo)
        {
        }

        public override long Value
        {
            get { return 1024; }
        }

        public override string ToString()
        {
            return string.Format("{0:#.##} KiB", this.Amount);
        }
    }
}
