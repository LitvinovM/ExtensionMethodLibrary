using System.Diagnostics;

namespace VolumeInfo.Extension
{
    public static partial class ExtensionVolumeInfo
    {

        #region VolumeByte

        [DebuggerStepThroughAttribute]
        public static VolumeByte ToByte(this VolumeInfo value)
        {
            return new VolumeByte(value);
        }

        #endregion


        #region VolumeGibibyte

        [DebuggerStepThroughAttribute]
        public static VolumeGibibyte ToGibibyte(this VolumeInfo value)
        {
            return new VolumeGibibyte(value);
        }

        #endregion


        #region VolumeKibibyte

        [DebuggerStepThroughAttribute]
        public static VolumeKibibyte ToKibibyte(this VolumeInfo value)
        {
            return new VolumeKibibyte(value);
        }

        #endregion


        #region VolumeMebibyte

        [DebuggerStepThroughAttribute]
        public static VolumeMebibyte ToMebibyte(this VolumeInfo value)
        {
            return new VolumeMebibyte(value);
        }

        #endregion


        #region VolumePebibyte

        [DebuggerStepThroughAttribute]
        public static VolumePebibyte ToPebibyte(this VolumeInfo value)
        {
            return new VolumePebibyte(value);
        }

        #endregion


        #region VolumeTebibyte

        [DebuggerStepThroughAttribute]
        public static VolumeTebibyte ToTebibyte(this VolumeInfo value)
        {
            return new VolumeTebibyte(value);
        }

        #endregion

    }
}