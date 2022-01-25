using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenHardwareMonitor.GUI {
  public partial class SerialForm : Form {
    private MainForm parent;
    public SerialForm(MainForm m) {
      InitializeComponent();
      parent = m;

    }
  }
}
