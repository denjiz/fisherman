using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface ILocationEditorView
    {
        void ShowErrorMessage(string text);

        void End();

        void ShowLocation(DomainModel.Location _editedLocation);

        void DisableLatitudeAndLongitudeChange();

        void SetFinishButtonText(string text);
    }
}
