using SDO.Infrastructure.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls
{
	public class ControlsManager
	{
		private BaseControl _baseControl;

        public ControlsManager()
        {
            _baseControl = new RequiredControl();
        }

        public bool MakeControls(IFileModel fileModel)
            => _baseControl.MakeControl(fileModel);
    }
}
