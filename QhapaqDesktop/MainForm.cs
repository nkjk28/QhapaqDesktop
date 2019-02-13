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
using QhapaqLibrary;

namespace QhapaqDesktop {
  public partial class MainForm : MetroForm {
    public MainForm() {
      InitializeComponent();
    }

    // key is menu name, value is menu detail
    Dictionary<string, QhapaqLibrary.Menu> Menus;

    private async void AddMenusToNodes() {
      Menus = new Dictionary<string, QhapaqLibrary.Menu>();
      var genres = await Qhapaq.GetGenres();
      for (int i = 0; i < genres.Length; i++) { 
        menuTree.Nodes.Add(genres[i].Name);
        foreach (var menu in await Qhapaq.GetMenus(genres[i].Id)) {
          if (menu == null) break;
          menuTree.Nodes[i].Nodes.Add(menu.Name);
          Menus.Add(menu.Name, menu);
        }
      }
      menuTree.ExpandAll();
    }

    private void MailForm_Load(object sender, EventArgs e) {
      AddMenusToNodes();
    }

    private void loginButton_Click(object sender, EventArgs e) {

    }

    private void menuTree_AfterSelect(object sender, TreeViewEventArgs e) {
      if (Menus.ContainsKey(menuTree.SelectedNode.Name)) {
        menuGrid.Rows.Clear();

        var ingredients = Menus[menuTree.SelectedNode.Name].Ingredients;
        foreach (var ingredient in ingredients) {
          menuGrid.Rows.Add(ingredient.Name, ingredient.Quantity + ingredient.Unit, ingredient.Cost, ingredient.Description);
        }
      }
    }
  }
}
