namespace FormsDemoApp;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private SimpleCircle theCircle;
    private Label outputLabel;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Text = "FormsDemoApp";
        this.BackColor = Color.FromArgb(255, 255, 255);

        theCircle = new SimpleCircle 
        {
            Location = new Point(140, 140),
            Size = new Size(120, 120),
            Radius = 50
        };
        theCircle.Click += theCircle_Click;
        this.Controls.Add(theCircle);

        outputLabel = new Label 
        {
            Location = new Point(10, 10),
            Size = new Size(200, 20),
            Text = "Hello World!"
        };
        outputLabel.DoubleClick += outputLabel_Click;
        this.Controls.Add(outputLabel);
    }

    #endregion
}
