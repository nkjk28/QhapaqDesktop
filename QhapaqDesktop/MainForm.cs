using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace QhapaqDesktop {
  public partial class MainForm : MetroForm {
    public MainForm() {
      InitializeComponent();
    }

    private void DebugControls() {
      menuGrid.Rows.Add("鮭", "1匹", "80円", "");
      menuGrid.Rows.Add("レモン", "2枚", "6円", "1切れは絞って、1切れは乗せる");
      menuGrid.Rows.Add("ネギ", "10g", "5円", "最後に乗せる");
    }

    private void MailForm_Load(object sender, EventArgs e) {
      DebugControls();
    }

    private void metroButton1_Click(object sender, EventArgs e) {

    }
  }
}
