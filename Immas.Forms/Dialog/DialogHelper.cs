﻿using System.Windows.Forms;

namespace Immas.Forms.Dialog
{
    public static class DialogHelper
    {
        public static DialogResult ShowDialog(string msg, DialogType dialogType = DialogType.OkOnly)
        {
            DialogForm dialogForm = new DialogForm(msg, dialogType);
            return dialogForm.ShowDialog();
        }

    }
}
