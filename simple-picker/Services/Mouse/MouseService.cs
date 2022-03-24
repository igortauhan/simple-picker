using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_picker.Services.Mouse
{
    public static class MouseService
    {
        public static Point GetMousePosition()
        {
            return Cursor.Position;
        }
    }
}
