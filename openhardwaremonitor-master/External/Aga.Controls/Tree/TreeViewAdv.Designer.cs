using System.Windows.Forms;

namespace Aga.Controls.Tree
{
	partial class TreeViewAdv
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
				if (_dragBitmap != null) _dragBitmap.Dispose();
				if (_dragTimer != null) _dragTimer.Dispose();
				if (_linePen != null) _linePen.Dispose();
				if (_markPen != null) _markPen.Dispose();
                if (_lightGrayPen != null) _lightGrayPen.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this._vScrollBar = new System.Windows.Forms.VScrollBar();
            this._hScrollBar = new System.Windows.Forms.HScrollBar();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _vScrollBar
            // 
            this._vScrollBar.LargeChange = 1;
            this._vScrollBar.Location = new System.Drawing.Point(0, 0);
            this._vScrollBar.Maximum = 0;
            this._vScrollBar.Name = "_vScrollBar";
            this._vScrollBar.Size = new System.Drawing.Size(13, 80);
            this._vScrollBar.TabIndex = 1;
            this._vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this._vScrollBar_Scroll);
            this._vScrollBar.ValueChanged += new System.EventHandler(this._vScrollBar_ValueChanged);
            // 
            // _hScrollBar
            // 
            this._hScrollBar.LargeChange = 1;
            this._hScrollBar.Location = new System.Drawing.Point(0, 0);
            this._hScrollBar.Maximum = 0;
            this._hScrollBar.Name = "_hScrollBar";
            this._hScrollBar.Size = new System.Drawing.Size(80, 13);
            this._hScrollBar.TabIndex = 2;
            this._hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this._hScrollBar_Scroll);
            this._hScrollBar.ValueChanged += new System.EventHandler(this._hScrollBar_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TreeViewAdv
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this._vScrollBar);
            this.Controls.Add(this._hScrollBar);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private VScrollBar _vScrollBar;
		private HScrollBar _hScrollBar;
		private ErrorProvider _errorProvider;
        private CheckBox checkBox1;
    }
}
