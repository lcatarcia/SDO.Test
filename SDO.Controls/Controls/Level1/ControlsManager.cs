using SDO.Infrastructure.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Level1
{
    public class ControlsManager
    {
        private Level1BaseControl _controlsChain;

        public ControlsManager()
        {
            _controlsChain = new RequiredControl();

            TypeAndLengthControl typeAndLengthControl = new();
            _controlsChain.SetNextControl(typeAndLengthControl);
        }

        public bool MakeControls(IFileModel fileModel)
            => _controlsChain.MakeControl(fileModel);
    }
}
