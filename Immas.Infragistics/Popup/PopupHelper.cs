using Infragistics.Win.UltraWinGrid;
using System.Windows.Forms;

namespace Immas.Infragistics.Popup
{
    public static class PopupHelper
    {
        public static DialogResult ShowComboBoxPopup(UltraGridCell cell)
        {
            ComboBoxPopupForm popupForm = new ComboBoxPopupForm(cell);
            return popupForm.ShowDialog();
        }
    }
}
