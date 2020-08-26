using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibFileManager.Model;

namespace LibFileManager.View {
	/// <summary>
	/// Логика взаимодействия для ControlDataGridBooks.xaml
	/// </summary>
	public partial class ControlDataGridBooks : UserControl {
		public ControlDataGridBooks() {
			InitializeComponent();

			CollectionBook = new List<Book>();
		}

		public IEnumerable<Book> CollectionBook { get; set; }
	}
}
