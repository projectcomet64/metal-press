using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using M64MM.Utils;
using M64MMPresser.Classes.RackTypes;
using M64MMPresser.Enums;
using M64MMPresser.KIO;
using M64MMPresser.Properties;

namespace M64MMPresser
{

    public static class Engine
    {

        public static FrmMain MainForm;

        // TODO: Make extension method for Vector3 "FromBytes"

        public static bool SyncToAnimation;

        public static Vector3 PreviousScale;

        public static Vector3 Scale
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] scaleValX = Core.ReadBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x2C, 4);
                byte[] scaleValY = Core.ReadBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x2C + 4, 4);
                byte[] scaleValZ = Core.ReadBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x2C + 8, 4);
                v.X = BitConverter.ToSingle(scaleValX, 0);
                v.Y = BitConverter.ToSingle(scaleValY, 00);
                v.Z = BitConverter.ToSingle(scaleValZ, 0);
                PreviousScale = v;
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X).Reverse().ToArray();
                byte[] valsY = BitConverter.GetBytes(value.Y).Reverse().ToArray();
                byte[] valsZ = BitConverter.GetBytes(value.Z).Reverse().ToArray();
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                PreviousScale = value;
                Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x2C, fullvals, true);
            }
        }

        public static Timeline mainTL;

        public static FloatKeyframeRack scaleXKeyframeRack = new(new Keyframe<float>(1), () => Scale.X)
        {
            Name = "Scale X"
        };
        public static FloatKeyframeRack scaleYKeyframeRack = new(new Keyframe<float>(1), () => Scale.Y)
        {
            Name = "Scale Y"
        };
        public static FloatKeyframeRack scaleZKeyframeRack = new(new Keyframe<float>(1), () => Scale.Z)
        {
            Name = "Scale Z"
        };

        public static void Init()
        {
            mainTL = new Timeline();
            mainTL.AddRack("scaleX", scaleXKeyframeRack);
            mainTL.AddRack("scaleY", scaleYKeyframeRack);
            mainTL.AddRack("scaleZ", scaleZKeyframeRack);

            scaleXKeyframeRack.OnCurrentFrameChanged += () =>
            {
                Scale = Scale with {X = scaleXKeyframeRack.CalculateInterpolation()}; MainForm.UpdateNumericUpDown(Direction.X);
            };
            scaleYKeyframeRack.OnCurrentFrameChanged += () =>
            {
                Scale = Scale with { Y = scaleYKeyframeRack.CalculateInterpolation() }; MainForm.UpdateNumericUpDown(Direction.Y);
            };
            scaleZKeyframeRack.OnCurrentFrameChanged += () =>
            {
                Scale = Scale with { Z = scaleZKeyframeRack.CalculateInterpolation() }; MainForm.UpdateNumericUpDown(Direction.Z);
            };
        }

    }
}
