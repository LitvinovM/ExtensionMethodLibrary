namespace VolumeInfo
{
    public sealed partial class VolumeByte : VolumeInfo
    {
        internal VolumeByte(double amount) 
            : base(amount)
        {
        }

        internal VolumeByte(VolumeInfo volumeInfo) 
            : base(volumeInfo)
        {
        }

        public override long Value
        {
            get { return 1; }
        }

        public override string ToString()
        {
            return string.Format("{0:#.##} B", this.Amount);
        }
    }
}
