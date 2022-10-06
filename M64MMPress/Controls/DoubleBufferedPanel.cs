using System.Windows.Forms;

namespace M64MMPresser.Controls
{
    public class DoubleBufferedPanel: Panel
    {
        public DoubleBufferedPanel()
        {
            DoubleBuffered = true;
        }
    }
}
