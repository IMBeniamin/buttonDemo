
namespace buttonDemo
{
    partial class Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 122);
            this.button1.TabIndex = 0;
            this.button1.Text = "DO STUFF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.AutoSizeChanged += new System.EventHandler(this.button1_autoSizeChanged);
            this.button1.Click += new System.EventHandler(this.button1_click);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.button1_dragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.button1_dragEnter);
            this.button1.DragOver += new System.Windows.Forms.DragEventHandler(this.button1_dragOver);
            this.button1.DragLeave += new System.EventHandler(this.button1_dragLeave);
            this.button1.Enter += new System.EventHandler(this.button1_enter);
            this.button1.Leave += new System.EventHandler(this.button1_leave);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_mouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_mouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_mouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_mouseHover);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_mouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_mouseUp);
            this.button1.Resize += new System.EventHandler(this.button1_resized);
            this.button1.StyleChanged += new System.EventHandler(this.button1_styleChange);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(179, 122);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controller";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Controller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Controller_FormClosed);
            this.Load += new System.EventHandler(this.Controller_Load);
            this.Shown += new System.EventHandler(this.Controller_Shown);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Controller_ControlAdded);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}

