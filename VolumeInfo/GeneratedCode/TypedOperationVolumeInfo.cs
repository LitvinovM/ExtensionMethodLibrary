using System;
using System.Diagnostics;

namespace VolumeInfo
{

    partial class VolumeByte
    {
        public static VolumeByte operator +(VolumeByte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeByte(mainValue.Amount + amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeByte operator -(VolumeByte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeByte(mainValue.Amount - amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeByte operator *(VolumeByte mainValue, double multiplier)
        {
            return new VolumeByte(mainValue.Amount * multiplier);
        }

        public static VolumeByte operator /(VolumeByte mainValue, double divider)
        {
            return new VolumeByte(mainValue.Amount / divider);
        }
    }

    partial class VolumeGibibyte
    {
        public static VolumeGibibyte operator +(VolumeGibibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeGibibyte(mainValue.Amount + amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeGibibyte operator -(VolumeGibibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeGibibyte(mainValue.Amount - amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeGibibyte operator *(VolumeGibibyte mainValue, double multiplier)
        {
            return new VolumeGibibyte(mainValue.Amount * multiplier);
        }

        public static VolumeGibibyte operator /(VolumeGibibyte mainValue, double divider)
        {
            return new VolumeGibibyte(mainValue.Amount / divider);
        }
    }

    partial class VolumeKibibyte
    {
        public static VolumeKibibyte operator +(VolumeKibibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeKibibyte(mainValue.Amount + amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeKibibyte operator -(VolumeKibibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeKibibyte(mainValue.Amount - amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeKibibyte operator *(VolumeKibibyte mainValue, double multiplier)
        {
            return new VolumeKibibyte(mainValue.Amount * multiplier);
        }

        public static VolumeKibibyte operator /(VolumeKibibyte mainValue, double divider)
        {
            return new VolumeKibibyte(mainValue.Amount / divider);
        }
    }

    partial class VolumeMebibyte
    {
        public static VolumeMebibyte operator +(VolumeMebibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeMebibyte(mainValue.Amount + amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeMebibyte operator -(VolumeMebibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeMebibyte(mainValue.Amount - amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeMebibyte operator *(VolumeMebibyte mainValue, double multiplier)
        {
            return new VolumeMebibyte(mainValue.Amount * multiplier);
        }

        public static VolumeMebibyte operator /(VolumeMebibyte mainValue, double divider)
        {
            return new VolumeMebibyte(mainValue.Amount / divider);
        }
    }

    partial class VolumePebibyte
    {
        public static VolumePebibyte operator +(VolumePebibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumePebibyte(mainValue.Amount + amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumePebibyte operator -(VolumePebibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumePebibyte(mainValue.Amount - amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumePebibyte operator *(VolumePebibyte mainValue, double multiplier)
        {
            return new VolumePebibyte(mainValue.Amount * multiplier);
        }

        public static VolumePebibyte operator /(VolumePebibyte mainValue, double divider)
        {
            return new VolumePebibyte(mainValue.Amount / divider);
        }
    }

    partial class VolumeTebibyte
    {
        public static VolumeTebibyte operator +(VolumeTebibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeTebibyte(mainValue.Amount + amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeTebibyte operator -(VolumeTebibyte mainValue, VolumeInfo addedValue)
        {
            var amountAddedValueInCurrentMeasurementUnit = addedValue.AmountByte / mainValue.Value;

            return new VolumeTebibyte(mainValue.Amount - amountAddedValueInCurrentMeasurementUnit);
        }

        public static VolumeTebibyte operator *(VolumeTebibyte mainValue, double multiplier)
        {
            return new VolumeTebibyte(mainValue.Amount * multiplier);
        }

        public static VolumeTebibyte operator /(VolumeTebibyte mainValue, double divider)
        {
            return new VolumeTebibyte(mainValue.Amount / divider);
        }
    }
}