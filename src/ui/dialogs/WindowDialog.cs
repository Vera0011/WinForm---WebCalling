namespace WebCalling;

public static class WindowDialog
{
    public static void ShowDialog(string messageError, string dialogName, string iconPath)
    {
        Form formResponse = new Form();
        Label labelResponse = new System.Windows.Forms.Label();

        labelResponse.AutoSize = false;
        labelResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        labelResponse.Dock = System.Windows.Forms.DockStyle.Fill;
        labelResponse.Text = messageError;

        formResponse.Size = new System.Drawing.Size(380, 200);
        formResponse.MaximizeBox = false;
        formResponse.FormBorderStyle = FormBorderStyle.FixedDialog;
        formResponse.StartPosition = FormStartPosition.CenterParent;
        formResponse.Icon = new Icon(iconPath);
        formResponse.Text = dialogName;

        formResponse.Controls.Add(labelResponse);
        formResponse.ShowDialog();
    }
}
