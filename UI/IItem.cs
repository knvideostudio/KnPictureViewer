using System;
using System.Collections.Generic;
using System.Text;

namespace KnPictureViewer.UI
{

    public interface IItem
    {
        string Description { get; }
        string Title { get; }
    }
}
