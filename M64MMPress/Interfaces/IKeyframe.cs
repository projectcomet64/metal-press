using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M64MMPresser.KIO
{
    public interface IKeyframe<TKeytype>
    {

        TKeytype CurrentValue { get; set; }
    }
}
