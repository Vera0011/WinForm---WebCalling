namespace WebCalling;

partial class WindowMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.search = new System.Windows.Forms.Button();
        this.exit = new System.Windows.Forms.Button();
        this.urlField = new System.Windows.Forms.TextBox();
        this.wordField = new System.Windows.Forms.TextBox();
        this.urlLabel = new System.Windows.Forms.Label();
        this.wordLabel = new System.Windows.Forms.Label();
        this.SuspendLayout();

        this.search.Text = "Search";
        this.search.Location = new System.Drawing.Point(132, 150);
        this.search.Click += new System.EventHandler(EventHandler.executeSearch);

        this.exit.Text = "Exit";
        this.exit.Location = new System.Drawing.Point(212, 150);
        this.exit.TabIndex = 1;
        this.exit.Click += new System.EventHandler(EventHandler.exitProgram);

        this.urlField.Location = new System.Drawing.Point(132, 50);
        this.urlField.Size = new System.Drawing.Size(220, 23);
        this.urlField.Name = "url_textbox";
        this.urlField.TabIndex = 2;

        this.wordField.Location = new System.Drawing.Point(132, 90);
        this.wordField.Size = new System.Drawing.Size(220, 23);
        this.wordField.Name = "word_textbox";
        this.wordField.TabIndex = 3;

        this.urlLabel.AutoSize = true;
        this.urlLabel.Text = "URL:";
        this.urlLabel.Location = new System.Drawing.Point(64, 50);
        this.urlLabel.Size = new System.Drawing.Size(50, 23);
        this.urlLabel.TabIndex = 4;

        this.wordLabel.AutoSize = true;
        this.wordLabel.Text = "Word:";
        this.wordLabel.Location = new System.Drawing.Point(64, 90);
        this.wordLabel.Size = new System.Drawing.Size(50, 23);
        this.wordLabel.TabIndex = 5;

        this.Size = new System.Drawing.Size(480, 400);
        this.StartPosition = FormStartPosition.Manual;
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.CenterToScreen();
        this.Icon = new Icon("./src/img/icon.ico");
        this.Text = "WebCalling";
        this.Controls.Add(this.search);
        this.Controls.Add(this.exit);
        this.Controls.Add(this.urlField);
        this.Controls.Add(this.wordField);
        this.Controls.Add(this.urlLabel);
        this.Controls.Add(this.wordLabel);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button search;
    private System.Windows.Forms.Button exit;
    private System.Windows.Forms.TextBox urlField;
    private System.Windows.Forms.TextBox wordField;
    private System.Windows.Forms.Label urlLabel;
    private System.Windows.Forms.Label wordLabel;
}
