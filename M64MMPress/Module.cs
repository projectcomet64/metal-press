using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Additions;
using M64MM.Utils;
using M64MMPresser.KIO;
using M64MMPresser.Properties;

namespace M64MMPresser
{
    public class Module : IModule
    {

        private const long CamStatBase = 0x3E001c;

        public string SafeName => "METAL Presser";

        public string Description => "Make mario go BOIOIOIOIOING";

        public Image AddonIcon => Resources.press_64;

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> tcl = new List<ToolCommand>();
            ToolCommand tc = new ToolCommand("Open Press...");
            tc.Summoned += (a, b) => { Engine.MainForm.Show(); };
            tcl.Add(tc);
            return tcl;
        }

        public void Initialize() {
            Engine.Init();
            Engine.MainForm = new FrmMain();
        }

        public void OnBaseAddressFound()
        {

        }

        public void OnBaseAddressZero()
        {

        }

        public void OnCoreEntAddressChange(uint addr)
        {
            if (Engine.mainTL != null)
            {
                Engine.mainTL.Playing = false;
            }
        }

        public void Reset()
        {
            if (Engine.mainTL != null) {
                Engine.mainTL.Playing = false;
            }
        }

        public void Update()
        {
            if (Engine.mainTL != null && Core.CoreEntityAddress > 0) {
                if (Engine.SyncToAnimation)
                {
                    Engine.mainTL.TrackheadPosition = Core.AnimationTimer;
                }
                else if (Engine.mainTL.Playing) {
                    Engine.mainTL.TrackheadPosition++;
                }
            }
            
        }
    }
}
