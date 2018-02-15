using System;
using System.Windows.Forms;
using System.IO;

public class Form1 : Form
{
    private FileSystemWatcher watcher;
    private delegate void UpdateWatchTextDelegate(string newText);

    public Form1()
    {
        InitializeComponent();

        this.watcher = new System.IO.FileSystemWatcher();
        this.watcher.Deleted += new System.IO.FileSystemEventHandler(this.OnDelete);
        this.watcher.Renamed += new System.IO.RenamedEventHandler(this.OnRenamed);
        this.watcher.Changed += new System.IO.FileSystemEventHandler(this.OnChanged);
        this.watcher.Created += new System.IO.FileSystemEventHandler(this.OnCreate);
        DirectoryInfo aDir = new DirectoryInfo("C:\\");
    }
    public void UpdateWatchText(string newText)
    {
        lblWatch.Text = newText;
    }
    public void OnChanged(object source, FileSystemEventArgs e)
    {
        try
        {
            StreamWriter sw = new StreamWriter("C:/Log.txt", true);
            sw.WriteLine("File: {0} {1}", e.FullPath, e.ChangeType.ToString());
            sw.Close();
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote change event to log");
        }
        catch (IOException)
        {
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
        }
    }
    public void OnRenamed(object source, RenamedEventArgs e)
    {
        try
        {
            StreamWriter sw = new StreamWriter("C:/Log.txt", true);
            sw.WriteLine("File renamed from {0} to {1}", e.OldName, e.FullPath);
            sw.Close();
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote renamed event to log");
        }
        catch (IOException)
        {
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
        }
    }
    public void OnDelete(object source, FileSystemEventArgs e)
    {
        try
        {
            StreamWriter sw = new StreamWriter("C:/Log.txt", true);
            sw.WriteLine("File: {0} Deleted", e.FullPath);
            sw.Close();
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote delete event to log");
        }
        catch (IOException)
        {
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
        }
    }

    public void OnCreate(object source, FileSystemEventArgs e)
    {
        try
        {
            StreamWriter sw = new StreamWriter("C:/FileLogs/Log.txt", true);
            sw.WriteLine("File: {0} Created", e.FullPath);
            sw.Close();
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote create event to log");
        }
        catch (IOException)
        {
            this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
        }
    }

    private void cmdBrowse_Click(object sender, EventArgs e)
    {
        if (FileDialog.ShowDialog() != DialogResult.Cancel)
        {
            txtLocation.Text = FileDialog.FileName;
            cmdWatch.Enabled = true;
        }
    }

    private void cmdWatch_Click(object sender, EventArgs e)
    {
        watcher.Path = Path.GetDirectoryName(txtLocation.Text);
        watcher.Filter = Path.GetFileName(txtLocation.Text);
        watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size;
        lblWatch.Text = "Watching " + txtLocation.Text;
        watcher.EnableRaisingEvents = true;
    }
    private void InitializeComponent()
    {
        this.txtLocation = new System.Windows.Forms.TextBox();
        this.cmdBrowse = new System.Windows.Forms.Button();
        this.cmdWatch = new System.Windows.Forms.Button();
        this.lblWatch = new System.Windows.Forms.Label();
        this.FileDialog = new System.Windows.Forms.OpenFileDialog();
        this.SuspendLayout();
        // 
        // txtLocation
        // 
        this.txtLocation.Location = new System.Drawing.Point(8, 26);
        this.txtLocation.Name = "txtLocation";
        this.txtLocation.Size = new System.Drawing.Size(184, 20);
        this.txtLocation.TabIndex = 0;
        // 
        // cmdBrowse
        // 
        this.cmdBrowse.Location = new System.Drawing.Point(208, 24);
        this.cmdBrowse.Name = "cmdBrowse";
        this.cmdBrowse.Size = new System.Drawing.Size(64, 24);
        this.cmdBrowse.TabIndex = 1;
        this.cmdBrowse.Text = "Browse...";
        this.cmdBrowse.UseVisualStyleBackColor = true;
        this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
        // 
        // cmdWatch
        // 
        this.cmdWatch.Enabled = false;
        this.cmdWatch.Location = new System.Drawing.Point(88, 56);
        this.cmdWatch.Name = "cmdWatch";
        this.cmdWatch.Size = new System.Drawing.Size(80, 32);
        this.cmdWatch.TabIndex = 2;
        this.cmdWatch.Text = "Watch!";
        this.cmdWatch.UseVisualStyleBackColor = true;
        this.cmdWatch.Click += new System.EventHandler(this.cmdWatch_Click);
        // 
        // lblWatch
        // 
        this.lblWatch.AutoSize = true;
        this.lblWatch.Location = new System.Drawing.Point(8, 104);
        this.lblWatch.Name = "lblWatch";
        this.lblWatch.Size = new System.Drawing.Size(0, 13);
        this.lblWatch.TabIndex = 3;
        // 
        // FileDialog
        // 
        this.FileDialog.FileName = "openFileDialog1";
        this.FileDialog.Filter = "All Files|*.*";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(296, 135);
        this.Controls.Add(this.lblWatch);
        this.Controls.Add(this.cmdWatch);
        this.Controls.Add(this.cmdBrowse);
        this.Controls.Add(this.txtLocation);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "File Monitor";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    private System.Windows.Forms.TextBox txtLocation;
    private System.Windows.Forms.Button cmdBrowse;
    private System.Windows.Forms.Button cmdWatch;
    private System.Windows.Forms.Label lblWatch;
    private System.Windows.Forms.OpenFileDialog FileDialog;
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}