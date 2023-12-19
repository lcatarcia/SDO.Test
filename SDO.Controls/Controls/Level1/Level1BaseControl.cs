using SDO.Infrastructure.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Level1
{
    public abstract class Level1BaseControl
    {
        protected Level1BaseControl NextControl { get; private set; }

        public void SetNextControl(Level1BaseControl next)
            => NextControl = next;

        public abstract bool MakeControl(IFileModel fileModel);
    }
}
