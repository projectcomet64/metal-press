using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M64MMPresser.Classes;

namespace M64MMPresser.KIO
{

    /// <summary>
    /// Used when the Timeline trackhead moves
    /// </summary>
    public class TrackheadChangedEventArgs : EventArgs
    {
        int _frame;

        public TrackheadChangedEventArgs(int frame)
        {
            _frame = frame;
        }

        public int Frame => _frame;
    }

    /// <summary>
    /// Used when any keyframe at any point is added or deleted in place (Current Status, for example)
    /// </summary>
    public class KeyframeChangedEventArgs : EventArgs
    {
        Keyframe _keyframe;
        ChangeType _change;
        string _rackId;

        public KeyframeChangedEventArgs(Keyframe keyframe, ChangeType change, string rackId)
        {
            _keyframe = keyframe;
            _change = change;
            _rackId = rackId;
        }

        public Keyframe Keyframe => _keyframe;

        public ChangeType Change => _change;

        public string RackId => _rackId;
    }

    /// <summary>
    /// Used when UncommittedChanges in a Timeline are cancelled
    /// </summary>
    public class ChangesCancelledEventArgs : EventArgs
    {

    }

    /// <summary>
    /// Used when UncommittedChanges in a Timeline are committed
    /// </summary>
    public class ChangesCommittedEventArgs : EventArgs
    {
        private IReadOnlyDictionary<string, UncommittedRackChange> _rackChanges;

        public ChangesCommittedEventArgs(IReadOnlyDictionary<string, UncommittedRackChange> rackChanges)
        {
            _rackChanges = rackChanges;
        }

        public IReadOnlyDictionary<string, UncommittedRackChange> RackChanges => _rackChanges;
    }

    /// <summary>
    /// Used when all keyframes in the uncommitted rack changes are removed from their racks
    /// </summary>
    public class KeyframeBulkChangedEventArgs : EventArgs
    {
        IReadOnlyDictionary<string, UncommittedRackChange> _rackChanges;
        ChangeType _change;
        KeyframeType? _changeType;

        public IReadOnlyDictionary<string, UncommittedRackChange> RackChanges => _rackChanges;

        public ChangeType Change => _change;

        public KeyframeBulkChangedEventArgs(IReadOnlyDictionary<string, UncommittedRackChange> rackChanges,
            ChangeType change, KeyframeType? newChange = null)
        {
            _rackChanges = rackChanges;
            _change = change;
        }
    }

    public enum ChangeType
    {
        ADDITION,
        DELETION,
        INTERP_CHANGE,
        MOVE
    }
}
