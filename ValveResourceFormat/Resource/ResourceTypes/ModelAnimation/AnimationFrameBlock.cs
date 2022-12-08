using ValveResourceFormat.Serialization;

namespace ValveResourceFormat.ResourceTypes.ModelAnimation
{
    public class AnimationFrameBlock
    {
        public int StartFrame { get; }
        public int EndFrame { get; }
        public long[] SegmentIndexArray { get; }

        public AnimationFrameBlock(IKeyValueCollection frameBlock)
        {
            StartFrame = frameBlock.GetInt32Property("m_nStartFrame");
            EndFrame = frameBlock.GetInt32Property("m_nEndFrame");
            SegmentIndexArray = frameBlock.GetIntegerArray("m_segmentIndexArray");
        }
    }
}
