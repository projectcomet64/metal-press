using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Utils;
using M64MMPresser.Controls;
using M64MMPresser.Enums;
using M64MMPresser.KIO;

namespace M64MMPresser
{
    public partial class FrmMain : Form
    {
        private TimelineRenderer _tL;

        public FrmMain()
        {
            InitializeComponent();
            _tL = new TimelineRenderer(Engine.mainTL);
            pnlTimeline.Controls.Add(_tL);
            _tL.Dock = DockStyle.Fill;
            Engine.mainTL.OnTrackheadChanged += (s, e) =>
            {
                if (Engine.mainTL.Playing) {
                    Invoke(new MethodInvoker(() => {
                        cbSync.Checked = false;
                    }));
                }
            };
        }

        protected override void OnShown(EventArgs e)
        {
            // if not beta 1 or greater, will die
            Core.UsingTurbo = true;
            Core.UsingTurbo = false;
            base.OnShown(e);
            _tL.Redraw();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void saveTimelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonTl = Engine.mainTL.SerializeToJson();
            SaveFileDialog _sfd = new SaveFileDialog();
            _sfd.Title = "Save Timeline JSON...";
            _sfd.AddExtension = true;
            _sfd.Filter = "Timeline JSON (*.json)|*.json";
            DialogResult result = _sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(_sfd.FileName, jsonTl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Couldn't write the file!\nError: {ex.Message}");
                }
            }
        }



        public void UpdateNumericUpDown(Direction nud)
        {
            Invoke(new MethodInvoker(() =>
            {
                switch (nud)
                {
                    case Direction.X:
                        nudScaleX.Value = (decimal)Engine.Scale.X * 100;
                        tbScaleX_Scroll(null, EventArgs.Empty);
                        break;
                    case Direction.Y:
                        nudScaleY.Value = (decimal)Engine.Scale.Y * 100;
                        tbScaleY_Scroll(null, EventArgs.Empty);
                        break;
                    case Direction.Z:
                        nudScaleZ.Value = (decimal)Engine.Scale.Z * 100;
                        tbScaleZ_Scroll(null, EventArgs.Empty);
                        break;
                    case Direction.ALL:
                        {
                            tbScaleX.Value = (int)Engine.Scale.X * 100;
                            tbScaleX_Scroll(null, EventArgs.Empty);
                            tbScaleY.Value = (int)Engine.Scale.Y * 100;
                            tbScaleY_Scroll(null, EventArgs.Empty);
                            tbScaleZ.Value = (int)Engine.Scale.Z * 100;
                            tbScaleZ_Scroll(null, EventArgs.Empty);
                            break;
                        }
                    default:
                        throw new ArgumentOutOfRangeException(nameof(nud), nud, null);
                }
            }));

        }

        private void loadTimelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Title = "Save Timeline JSON...";
            ofd.AddExtension = true;
            ofd.Filter = "Timeline JSON (*.json)|*.json";
            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK) return;
            bool couldLoad = Engine.mainTL.DeserializeFromJson(File.ReadAllText(ofd.FileName));
            if (!couldLoad) MessageBox.Show("Error while loading into Timeline. Probably corrupt JSON.");

        }

        private void aboutKIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout _about = new frmAbout();
            _about.ShowDialog();
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show(
                    "Are you sure you want to do that\nIt really is not undoable! At least save your progress in File > Save Timeline...",
                    "Hol up", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                Engine.mainTL.WipeEverything();
                UpdateNumericUpDown(Direction.ALL);
            }
        }

        private void btnCollapseTl_Click(object sender, EventArgs e)
        {
            bool collapse = !scMain.Panel2Collapsed;
            int newHeight;

            //lol
            if (collapse)
            {
                newHeight = (Height - scMain.Panel2.Height);
                scMain.Panel2Collapsed = true;
            }
            else
            {
                scMain.Panel2Collapsed = collapse;
                newHeight = (Height + scMain.Panel2.Height);

            }
            Height = newHeight;

        }

        public void SyncScalesVisual()
        {
            Invoke(new MethodInvoker(() =>
            {
                tbScaleX.Scroll -= tbScaleX_Scroll;
                tbScaleY.Scroll -= tbScaleY_Scroll;
                tbScaleZ.Scroll -= tbScaleZ_Scroll;
                tbScaleX.Value = (int)(nudScaleX.Value * 10);
                tbScaleY.Value = (int)(nudScaleY.Value * 10);
                tbScaleZ.Value = (int)(nudScaleZ.Value * 10);
                tbScaleX.Scroll += tbScaleX_Scroll;
                tbScaleY.Scroll += tbScaleY_Scroll;
                tbScaleZ.Scroll += tbScaleZ_Scroll;
            }));

        }

        public void SyncScales(decimal value)
        {
            nudScaleX.Value = nudScaleY.Value = nudScaleZ.Value = value;

        }


        // Gonna be real honest with you: I hate this solution

        private void tbScaleX_Scroll(object sender, EventArgs e)
        {
            nudScaleX.Value = (decimal)tbScaleX.Value / 10;

            if (cbSync.Checked)
            {
                SyncScales(nudScaleX.Value);
                if (cbAddOnChange.Checked) {
                    Engine.scaleXKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    Engine.scaleYKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    Engine.scaleZKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    _tL.Refresh();
                }
                return;
            }

            if (cbAddOnChange.Checked && sender != null)
            {
                Engine.scaleXKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                _tL.Refresh();
            }
        }

        private void tbScaleY_Scroll(object sender, EventArgs e)
        {
            nudScaleY.Value = (decimal)tbScaleY.Value / 10;

            if (cbSync.Checked)
            {
                SyncScales(nudScaleY.Value);
                if (cbAddOnChange.Checked)
                {
                    Engine.scaleXKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    Engine.scaleYKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    Engine.scaleZKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    _tL.Refresh();
                }
                return;
            }

            if (cbAddOnChange.Checked && sender != null)
            {
                Engine.scaleYKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                _tL.Refresh();
            }
        }

        private void tbScaleZ_Scroll(object sender, EventArgs e)
        {
            nudScaleZ.Value = (decimal)tbScaleZ.Value / 10;

            if (cbSync.Checked)
            {
                SyncScales(nudScaleZ.Value);
                if (cbAddOnChange.Checked)
                {
                    Engine.scaleXKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    Engine.scaleYKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    Engine.scaleZKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                    _tL.Refresh();
                }
                return;
            }

            if (cbAddOnChange.Checked && sender != null)
            {
                Engine.scaleZKeyframeRack.AddCurrentStateAtPosition(Engine.mainTL.TrackheadPosition);
                _tL.Refresh();
            }
        }

        private void cbSyncWithComposer_CheckedChanged(object sender, EventArgs e)
        {
            Engine.SyncToAnimation = cbSyncWithComposer.Checked;
        }

        private void nudUpdate(object sender, EventArgs e)
        {
            Vector3 newScale = new Vector3((float)nudScaleX.Value / 100, (float)nudScaleY.Value / 100,
                (float)nudScaleZ.Value / 100);
            Engine.Scale = newScale;

            SyncScalesVisual();
        }

        private void btnEnsemble_Click(object sender, EventArgs e)
        {
            // JR RA
            Core.WriteBytes(Core.BaseAddress + 0x253588, new byte[] { 0x03, 0xE0, 0x00, 0x08 }.Reverse().ToArray());
        }

        private void cbSync_CheckedChanged(object sender, EventArgs e)
        {
            cbAddOnChange.Checked = false;
            cbAddOnChange.Enabled = !cbSync.Checked;
        }
    }
}
