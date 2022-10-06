using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using M64MMPresser.Extensions;
using M64MMPresser.KIO;
using Newtonsoft.Json;

namespace M64MMPresser.Classes.RackTypes
{
    [JsonObject]
    public class FloatKeyframeRack : KeyframeRack<float>
    {
        [JsonConstructor]
        protected FloatKeyframeRack(List<Keyframe<float>> list, string name) : base(list, name) { }

        public FloatKeyframeRack(Keyframe<float> initialKeyframe, Func<float> valgetter) : base(initialKeyframe, valgetter) { }

        public FloatKeyframeRack(Func<float> valgetter) : base(valgetter) { }

        public override float Lerp(Keyframe<float> start, Keyframe<float> end, float position) =>
            MathExtensions.Lerp(start, end, position);

        public override float NBezier(Keyframe<float>[] points, float position) =>
            MathExtensions.BezierInterpolate(points.Select(x => x.CurrentValue).ToArray(), position);

        public override float NShake(Keyframe<float>[] points)
        {
            // TODO: Implement shaking
            return points[0].CurrentValue;
        }
    }

    [JsonObject]
    public class Vector3KeyframeRack : KeyframeRack<Vector3>
    {
        [JsonConstructor]
        protected Vector3KeyframeRack(List<Keyframe<Vector3>> list, string name) : base(list, name)
        {

        }

        public Vector3KeyframeRack(Keyframe<Vector3> initialKeyframe, Func<Vector3> valgetter) : base(initialKeyframe, valgetter) { }

        public Vector3KeyframeRack(Func<Vector3> valgetter) : base(valgetter) { }

        public override Vector3 Lerp(Keyframe<Vector3> start, Keyframe<Vector3> end, float position)
        {
            return Vector3.Lerp(start.CurrentValue, end.CurrentValue, position);
        }

        public override Vector3 NBezier(Keyframe<Vector3>[] points, float position)
        {
            return MathExtensions.BezierInterpolate(points.Select(x => x.CurrentValue).ToArray(), position);
        }

        public override Vector3 NShake(Keyframe<Vector3>[] points)
        {
            // TODO: Implement shaking
            return points[0].CurrentValue;
        }
    }

    [JsonObject]
    public class XYAngleKeyframeRack : KeyframeRack<XYAngle>
    {
        [JsonConstructor]
        protected XYAngleKeyframeRack(List<Keyframe<XYAngle>> list, string name) : base(list, name)
        {

        }
        public XYAngleKeyframeRack(Keyframe<XYAngle> initialKeyframe, Func<XYAngle> valgetter) : base(initialKeyframe, valgetter) { }

        public XYAngleKeyframeRack(Func<XYAngle> valgetter) : base(valgetter) { }

        public override XYAngle Lerp(Keyframe<XYAngle> start, Keyframe<XYAngle> end, float position)
        {
            return XYAngle.Lerp(start.CurrentValue, end.CurrentValue, position);
        }

        public override XYAngle NBezier(Keyframe<XYAngle>[] points, float position)
        {
            return MathExtensions.BezierInterpolate(points.Select(x => x.CurrentValue).ToArray(), position);
        }

        public override XYAngle NShake(Keyframe<XYAngle>[] points)
        {
            // TODO: Implement shaking
            return points[0].CurrentValue;
        }
    }
}